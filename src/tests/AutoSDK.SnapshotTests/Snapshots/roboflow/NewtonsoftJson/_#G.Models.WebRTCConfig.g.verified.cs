//HintName: G.Models.WebRTCConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebRTCConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iceServers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RTCIceServer> IceServers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCConfig" /> class.
        /// </summary>
        /// <param name="iceServers"></param>
        public WebRTCConfig(
            global::System.Collections.Generic.IList<global::G.RTCIceServer> iceServers)
        {
            this.IceServers = iceServers ?? throw new global::System.ArgumentNullException(nameof(iceServers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCConfig" /> class.
        /// </summary>
        public WebRTCConfig()
        {
        }
    }
}