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
        [global::System.Text.Json.Serialization.JsonPropertyName("iceServers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RTCIceServer> IceServers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCConfig" /> class.
        /// </summary>
        /// <param name="iceServers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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