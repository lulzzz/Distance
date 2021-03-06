//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distance.Diagnostics.Lan {
    using Distance.Runtime;
    using Distance.Utils;
    using System;
    
    
    public class IpPacket : DistanceFact {
        
        private Int32 _FrameNumber;
        
        private String _EthSrc;
        
        private String _EthDst;
        
        private String _IpSrc;
        
        private String _IpDst;
        
        public static string Filter = "ip";
        
        public static string[] Fields = new string[] {
                "frame.number",
                "eth.src",
                "eth.dst",
                "ip.src",
                "ip.dst"};
        
        [FieldName("frame.number")]
        public virtual Int32 FrameNumber {
            get {
                return this._FrameNumber;
            }
            set {
                this._FrameNumber = value;
            }
        }
        
        [FieldName("eth.src")]
        public virtual String EthSrc {
            get {
                return this._EthSrc;
            }
            set {
                this._EthSrc = value;
            }
        }
        
        [FieldName("eth.dst")]
        public virtual String EthDst {
            get {
                return this._EthDst;
            }
            set {
                this._EthDst = value;
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
        
        public override string ToString() {
            return string.Format("IpPacket: frame.number={0} eth.src={1} eth.dst={2} ip.src={3} ip.dst={4}", this.FrameNumber, this.EthSrc, this.EthDst, this.IpSrc, this.IpDst);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.FrameNumber, this.EthSrc, this.EthDst, this.IpSrc, this.IpDst);
        }
        
        public override bool Equals(object obj) {
            IpPacket that = obj as IpPacket;
            return ((((((that != null) 
                        && object.Equals(this.FrameNumber, that.FrameNumber)) 
                        && object.Equals(this.EthSrc, that.EthSrc)) 
                        && object.Equals(this.EthDst, that.EthDst)) 
                        && object.Equals(this.IpSrc, that.IpSrc)) 
                        && object.Equals(this.IpDst, that.IpDst));
        }
        
        public static IpPacket Create(string[] values) {
            IpPacket newObj = new IpPacket();
            newObj._FrameNumber = values[0].ToInt32();
            newObj._EthSrc = values[1].ToString();
            newObj._EthDst = values[2].ToString();
            newObj._IpSrc = values[3].ToString();
            newObj._IpDst = values[4].ToString();
            return newObj;
        }
    }
    
    public class AddressMapping {
        
        private String _IpAddr;
        
        private String _EthAddr;
        
        [FieldName("ip.addr")]
        public virtual String IpAddr {
            get {
                return this._IpAddr;
            }
            set {
                this._IpAddr = value;
            }
        }
        
        [FieldName("eth.addr")]
        public virtual String EthAddr {
            get {
                return this._EthAddr;
            }
            set {
                this._EthAddr = value;
            }
        }
        
        public override string ToString() {
            return string.Format("AddressMapping: ip.addr={0} eth.addr={1}", this.IpAddr, this.EthAddr);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.IpAddr, this.EthAddr);
        }
        
        public override bool Equals(object obj) {
            AddressMapping that = obj as AddressMapping;
            return (((that != null) 
                        && object.Equals(this.IpAddr, that.IpAddr)) 
                        && object.Equals(this.EthAddr, that.EthAddr));
        }
    }
    
    public class DuplicateAddressDetected : Distance.Runtime.DistanceEvent {
        
        private String _IpAddress;
        
        private String[] _EthAddresses;
        
        [FieldName("ip.address")]
        public virtual String IpAddress {
            get {
                return this._IpAddress;
            }
            set {
                this._IpAddress = value;
            }
        }
        
        [FieldName("eth.addresses")]
        public virtual String[] EthAddresses {
            get {
                return this._EthAddresses;
            }
            set {
                this._EthAddresses = value;
            }
        }
        
        public override string Name {
            get {
                return "DuplicateAddressDetected";
            }
        }
        
        public override string Message {
            get {
                return string.Format("Two or more MAC addresses use network address {0}.", this.IpAddress);
            }
        }
        
        public override Distance.Runtime.EventSeverity Severity {
            get {
                return Distance.Runtime.EventSeverity.Error;
            }
        }
        
        public override string ToString() {
            return string.Format("DuplicateAddressDetected: ip.address={0} eth.addresses={1}", this.IpAddress, this.EthAddresses);
        }
        
        public override int GetHashCode() {
            return Distance.Utils.HashFunction.GetHashCode(this.IpAddress, this.EthAddresses);
        }
        
        public override bool Equals(object obj) {
            DuplicateAddressDetected that = obj as DuplicateAddressDetected;
            return (((that != null) 
                        && object.Equals(this.IpAddress, that.IpAddress)) 
                        && object.Equals(this.EthAddresses, that.EthAddresses));
        }
    }
}
