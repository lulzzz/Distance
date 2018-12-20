﻿using Pidgin;
using Pidgin.Expression;
using System;
using System.Collections.Immutable;
using static Pidgin.Parser;

namespace Distance.Engine.Builder
{
    public static class LambdaExpressionParser
    {
        private static Parser<char, T> Token<T>(Parser<char, T> token)
            => Try(token).Before(SkipWhitespaces);

        private static Parser<char, string> Token(string token)
            => Token(String(token));

        private static Parser<char, T> Parenthesised<T>(Parser<char, T> parser)
            => parser.Between(Token("("), Token(")"));

        public static Parser<char, string> StrConstant 
            => AnyCharExcept('"').ManyString().Between(Token("\""), Token("\""));

        private static Parser<char, Func<Expression, Expression, Expression>> Binary(Parser<char, BinaryOperatorType> op)
            => op.Select<Func<Expression, Expression, Expression>>(type => (l, r) => new BinaryOp(type, l, r));

        private static Parser<char, Func<Expression, Expression>> Unary(Parser<char, UnaryOperatorType> op)
            => op.Select<Func<Expression, Expression>>(type => o => new UnaryOp(type, o));

        #region Binary Artihmetic Operations
        private static readonly Parser<char, Func<Expression, Expression, Expression>> Add
            = Binary(Token("+").ThenReturn(BinaryOperatorType.Add));

        private static readonly Parser<char, Func<Expression, Expression, Expression>> Subtract
            = Binary(Token("-").ThenReturn(BinaryOperatorType.Add));

        private static readonly Parser<char, Func<Expression, Expression, Expression>> Multiply
            = Binary(Token("*").ThenReturn(BinaryOperatorType.Mul));

        private static readonly Parser<char, Func<Expression, Expression, Expression>> Divide
            = Binary(Token("/").ThenReturn(BinaryOperatorType.Mul));

        private static readonly Parser<char, Func<Expression, Expression, Expression>> Modulo
            = Binary(Token("%").ThenReturn(BinaryOperatorType.Mul));

        #endregion
        #region Bitwise Operations
        // And         &
        // Or          |
        // ExclusiveOr ^

        #endregion
        #region Shift Operations
        // LetShift <<
        // RightShift >>
        #endregion
        #region Conditional Boolean Operations
        // AndAlso &&
        // OrElse  ||
        #endregion
        #region Comparison Operations
        // Equal
        // NotEqual
        // GreaterThanOrEqual
        // GreaterThan
        // LessThan
        // LessThanOrEqual
        #endregion

        #region Unary Operators
        private static readonly Parser<char, Func<Expression, Expression>> Negate
            = Unary(Token("-").ThenReturn(UnaryOperatorType.Negate));

        private static readonly Parser<char, Func<Expression, Expression>> Complement
            = Unary(Token("~").ThenReturn(UnaryOperatorType.Complement));

        private static readonly Parser<char, Func<Expression, Expression>> Not
            = Unary(Token("!").ThenReturn(UnaryOperatorType.Not));

        #endregion

        private static readonly Parser<char, Expression> Identifier
            = Token(Letter.Then(LetterOrDigit.Or(Char('.')).ManyString(), (h, t) => h + t))
                .Select<Expression>(name => new Identifier(name))
                .Labelled("identifier");

        private static readonly Parser<char, Expression> IntegerLiteral
            = Token(Num)
                .Select<Expression>(value => new Literal<int>(value))
                .Labelled("integer literal");

        private static readonly Parser<char, Expression> StringLiteral
            = Token(StrConstant)
                .Select<Expression>(value => new Literal<string>(value))
                .Labelled("string literal");


        private static Parser<char, Expression> BuildExpressionParser()
        {
            Parser<char, Expression> expr = null;

            var term = OneOf(
                Identifier,
                IntegerLiteral,
                Parenthesised(Rec(() => expr)).Labelled("parenthesised expression")
            );

            var call = Parenthesised(Rec(() => expr).Separated(Token(",")))
                .Select<Func<Expression, Expression>>(args => method => new Call(method, args.ToImmutableArray()))
                .Labelled("function call");

            expr = ExpressionParser.Build(
                term,
                new[]
                {
                    Operator.PostfixChainable(call),
                    Operator.Prefix(Negate).And(Operator.Prefix(Complement)),
                    Operator.InfixL(Multiply),
                    Operator.InfixL(Add)
                }
            ).Labelled("expression");

            return expr;
        }

        private static readonly Parser<char, Expression> m_expression = BuildExpressionParser();

        public static Expression ParseOrThrow(string input)
            => m_expression.ParseOrThrow(input);
    }
}
