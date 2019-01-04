//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distance.Diagnostics.Dns {
    using Distance.Runtime;
    using Distance.Utils;
    using System;
    
    
    public class DnsPacket {
        
        private Int32 _FrameNumber;
        
        private String _IpSrc;
        
        private String _IpDst;
        
        private String _DnsId;
        
        private Boolean _DnsFlagsResponse;
        
        private Int32 _DnsFlagsRcode;
        
        private Double _DnsTime;
        
        private String _DnsQryName;
        
        public static string Filter = "dns";
        
        public static string[] Fields = new string[] {
                "frame.number",
                "ip.src",
                "ip.dst",
                "dns.id",
                "dns.flags.response",
                "dns.flags.rcode",
                "dns.time",
                "dns.qry.name"};
        
        [FieldName("frame.number")]
        public virtual Int32 FrameNumber {
            get {
                return this._FrameNumber;
            }
            set {
                this._FrameNumber = value;
            }
        }
        
        [FieldName("ip.src")]
        public virtual String IpSrc {
            get {
                return this._IpSrc;
            }
            set {
                this._IpSrc = value;
            }
        }
        
        [FieldName("ip.dst")]
        public virtual String IpDst {
            get {
                return this._IpDst;
            }
            set {
                this._IpDst = value;
            }
        }
        
        [FieldName("dns.id")]
        public virtual String DnsId {
            get {
                return this._DnsId;
            }
            set {
                this._DnsId = value;
            }
        }
        
        [FieldName("dns.flags.response")]
        public virtual Boolean DnsFlagsResponse {
            get {
                return this._DnsFlagsResponse;
            }
            set {
                this._DnsFlagsResponse = value;
            }
        }
        
        [FieldName("dns.flags.rcode")]
        public virtual Int32 DnsFlagsRcode {
            get {
                return this._DnsFlagsRcode;
            }
            set {
                this._DnsFlagsRcode = value;
            }
        }
        
        [FieldName("dns.time")]
        public virtual Double DnsTime {
            get {
                return this._DnsTime;
            }
            set {
                this._DnsTime = value;
            }
        }
        
        [FieldName("dns.qry.name")]
        public virtual String DnsQryName {
            get {
                return this._DnsQryName;
            }
            set {
                this._DnsQryName = value;
            }
        }
        
        public override string ToString() {
            return string.Format("DnsPacket: frame.number={0} ip.src={1} ip.dst={2} dns.id={3} dns.flags.response={" +
                    "4} dns.flags.rcode={5} dns.time={6} dns.qry.name={7}", this.FrameNumber, this.IpSrc, this.IpDst, this.DnsId, this.DnsFlagsResponse, this.DnsFlagsRcode, this.DnsTime, this.DnsQryName);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.FrameNumber, this.IpSrc, this.IpDst, this.DnsId, this.DnsFlagsResponse, this.DnsFlagsRcode, this.DnsTime, this.DnsQryName);
        }
        
        public override bool Equals(object obj) {
            DnsPacket that = obj as DnsPacket;
            return (((((((((that != null) 
                        && object.Equals(this.FrameNumber, that.FrameNumber)) 
                        && object.Equals(this.IpSrc, that.IpSrc)) 
                        && object.Equals(this.IpDst, that.IpDst)) 
                        && object.Equals(this.DnsId, that.DnsId)) 
                        && object.Equals(this.DnsFlagsResponse, that.DnsFlagsResponse)) 
                        && object.Equals(this.DnsFlagsRcode, that.DnsFlagsRcode)) 
                        && object.Equals(this.DnsTime, that.DnsTime)) 
                        && object.Equals(this.DnsQryName, that.DnsQryName));
        }
        
        public static DnsPacket Create(string[] values) {
            DnsPacket newObj = new DnsPacket();
            newObj._FrameNumber = values[0].ToInt32();
            newObj._IpSrc = values[1].ToString();
            newObj._IpDst = values[2].ToString();
            newObj._DnsId = values[3].ToString();
            newObj._DnsFlagsResponse = values[4].ToBoolean();
            newObj._DnsFlagsRcode = values[5].ToInt32();
            newObj._DnsTime = values[6].ToDouble();
            newObj._DnsQryName = values[7].ToString();
            return newObj;
        }
    }
    
    public class QueryResponse {
        
        private DnsPacket _Query;
        
        private DnsPacket _Response;
        
        [FieldName("query")]
        public virtual DnsPacket Query {
            get {
                return this._Query;
            }
            set {
                this._Query = value;
            }
        }
        
        [FieldName("response")]
        public virtual DnsPacket Response {
            get {
                return this._Response;
            }
            set {
                this._Response = value;
            }
        }
        
        public override string ToString() {
            return string.Format("QueryResponse: query={0} response={1}", this.Query, this.Response);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.Query, this.Response);
        }
        
        public override bool Equals(object obj) {
            QueryResponse that = obj as QueryResponse;
            return (((that != null) 
                        && object.Equals(this.Query, that.Query)) 
                        && object.Equals(this.Response, that.Response));
        }
    }
    
    public class ResponseError {
        
        private DnsPacket _Query;
        
        private DnsPacket _Response;
        
        [FieldName("query")]
        public virtual DnsPacket Query {
            get {
                return this._Query;
            }
            set {
                this._Query = value;
            }
        }
        
        [FieldName("response")]
        public virtual DnsPacket Response {
            get {
                return this._Response;
            }
            set {
                this._Response = value;
            }
        }
        
        public override string ToString() {
            return string.Format("ResponseError: query={0} response={1}", this.Query, this.Response);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.Query, this.Response);
        }
        
        public override bool Equals(object obj) {
            ResponseError that = obj as ResponseError;
            return (((that != null) 
                        && object.Equals(this.Query, that.Query)) 
                        && object.Equals(this.Response, that.Response));
        }
    }
    
    public class NoResponse {
        
        private DnsPacket _Query;
        
        [FieldName("query")]
        public virtual DnsPacket Query {
            get {
                return this._Query;
            }
            set {
                this._Query = value;
            }
        }
        
        public override string ToString() {
            return string.Format("NoResponse: query={0}", this.Query);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.Query);
        }
        
        public override bool Equals(object obj) {
            NoResponse that = obj as NoResponse;
            return ((that != null) 
                        && object.Equals(this.Query, that.Query));
        }
    }
    
    public class LateResponse {
        
        private DnsPacket _Query;
        
        private DnsPacket _Response;
        
        private Double _Delay;
        
        [FieldName("query")]
        public virtual DnsPacket Query {
            get {
                return this._Query;
            }
            set {
                this._Query = value;
            }
        }
        
        [FieldName("response")]
        public virtual DnsPacket Response {
            get {
                return this._Response;
            }
            set {
                this._Response = value;
            }
        }
        
        [FieldName("delay")]
        public virtual Double Delay {
            get {
                return this._Delay;
            }
            set {
                this._Delay = value;
            }
        }
        
        public override string ToString() {
            return string.Format("LateResponse: query={0} response={1} delay={2}", this.Query, this.Response, this.Delay);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.Query, this.Response, this.Delay);
        }
        
        public override bool Equals(object obj) {
            LateResponse that = obj as LateResponse;
            return ((((that != null) 
                        && object.Equals(this.Query, that.Query)) 
                        && object.Equals(this.Response, that.Response)) 
                        && object.Equals(this.Delay, that.Delay));
        }
    }
    
    public class DnsServer {
        
        private String _IpAddress;
        
        [FieldName("ip.address")]
        public virtual String IpAddress {
            get {
                return this._IpAddress;
            }
            set {
                this._IpAddress = value;
            }
        }
        
        public override string ToString() {
            return string.Format("DnsServer: ip.address={0}", this.IpAddress);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.IpAddress);
        }
        
        public override bool Equals(object obj) {
            DnsServer that = obj as DnsServer;
            return ((that != null) 
                        && object.Equals(this.IpAddress, that.IpAddress));
        }
    }
}
