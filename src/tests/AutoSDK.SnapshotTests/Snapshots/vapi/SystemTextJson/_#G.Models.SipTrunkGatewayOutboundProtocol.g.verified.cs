//HintName: G.Models.SipTrunkGatewayOutboundProtocol.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the protocol to use for SIP signaling outbound calls. Default is udp.<br/>
    /// @default udp
    /// </summary>
    public enum SipTrunkGatewayOutboundProtocol
    {
        /// <summary>
        /// 
        /// </summary>
        Tcp,
        /// <summary>
        /// 
        /// </summary>
        Tls,
        /// <summary>
        /// 
        /// </summary>
        TlsSrtp,
        /// <summary>
        /// 
        /// </summary>
        Udp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SipTrunkGatewayOutboundProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SipTrunkGatewayOutboundProtocol value)
        {
            return value switch
            {
                SipTrunkGatewayOutboundProtocol.Tcp => "tcp",
                SipTrunkGatewayOutboundProtocol.Tls => "tls",
                SipTrunkGatewayOutboundProtocol.TlsSrtp => "tls/srtp",
                SipTrunkGatewayOutboundProtocol.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SipTrunkGatewayOutboundProtocol? ToEnum(string value)
        {
            return value switch
            {
                "tcp" => SipTrunkGatewayOutboundProtocol.Tcp,
                "tls" => SipTrunkGatewayOutboundProtocol.Tls,
                "tls/srtp" => SipTrunkGatewayOutboundProtocol.TlsSrtp,
                "udp" => SipTrunkGatewayOutboundProtocol.Udp,
                _ => null,
            };
        }
    }
}