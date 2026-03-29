//HintName: G.Models.SipTrunkGateway.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipTrunkGateway
    {
        /// <summary>
        /// This is the address of the gateway. It can be an IPv4 address like 1.1.1.1 or a fully qualified domain name like my-sip-trunk.pstn.twilio.com.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// This is the port number of the gateway. Default is 5060.<br/>
        /// @default 5060
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("port")]
        public double? Port { get; set; }

        /// <summary>
        /// This is the netmask of the gateway. Defaults to 32.<br/>
        /// @default 32
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("netmask")]
        public double? Netmask { get; set; }

        /// <summary>
        /// This is whether inbound calls are allowed from this gateway. Default is true.<br/>
        /// @default true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inboundEnabled")]
        public bool? InboundEnabled { get; set; }

        /// <summary>
        /// This is whether outbound calls should be sent to this gateway. Default is true.<br/>
        /// Note, if netmask is less than 32, it doesn't affect the outbound IPs that are tried. 1 attempt is made to `ip:port`.<br/>
        /// @default true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outboundEnabled")]
        public bool? OutboundEnabled { get; set; }

        /// <summary>
        /// This is the protocol to use for SIP signaling outbound calls. Default is udp.<br/>
        /// @default udp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outboundProtocol")]
        public global::G.SipTrunkGatewayOutboundProtocol? OutboundProtocol { get; set; }

        /// <summary>
        /// This is whether to send options ping to the gateway. This can be used to check if the gateway is reachable. Default is false.<br/>
        /// This is useful for high availability setups where you want to check if the gateway is reachable before routing calls to it. Note, if no gateway for a trunk is reachable, outbound calls will be rejected.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optionsPingEnabled")]
        public bool? OptionsPingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkGateway" /> class.
        /// </summary>
        /// <param name="ip">
        /// This is the address of the gateway. It can be an IPv4 address like 1.1.1.1 or a fully qualified domain name like my-sip-trunk.pstn.twilio.com.
        /// </param>
        /// <param name="port">
        /// This is the port number of the gateway. Default is 5060.<br/>
        /// @default 5060
        /// </param>
        /// <param name="netmask">
        /// This is the netmask of the gateway. Defaults to 32.<br/>
        /// @default 32
        /// </param>
        /// <param name="inboundEnabled">
        /// This is whether inbound calls are allowed from this gateway. Default is true.<br/>
        /// @default true
        /// </param>
        /// <param name="outboundEnabled">
        /// This is whether outbound calls should be sent to this gateway. Default is true.<br/>
        /// Note, if netmask is less than 32, it doesn't affect the outbound IPs that are tried. 1 attempt is made to `ip:port`.<br/>
        /// @default true
        /// </param>
        /// <param name="outboundProtocol">
        /// This is the protocol to use for SIP signaling outbound calls. Default is udp.<br/>
        /// @default udp
        /// </param>
        /// <param name="optionsPingEnabled">
        /// This is whether to send options ping to the gateway. This can be used to check if the gateway is reachable. Default is false.<br/>
        /// This is useful for high availability setups where you want to check if the gateway is reachable before routing calls to it. Note, if no gateway for a trunk is reachable, outbound calls will be rejected.<br/>
        /// @default false
        /// </param>
        public SipTrunkGateway(
            string ip,
            double? port,
            double? netmask,
            bool? inboundEnabled,
            bool? outboundEnabled,
            global::G.SipTrunkGatewayOutboundProtocol? outboundProtocol,
            bool? optionsPingEnabled)
        {
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Port = port;
            this.Netmask = netmask;
            this.InboundEnabled = inboundEnabled;
            this.OutboundEnabled = outboundEnabled;
            this.OutboundProtocol = outboundProtocol;
            this.OptionsPingEnabled = optionsPingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkGateway" /> class.
        /// </summary>
        public SipTrunkGateway()
        {
        }
    }
}