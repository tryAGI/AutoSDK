//HintName: G.Models.InitLiveKitRoomTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitLiveKitRoomTransport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InitLiveKitRoomTransportProviderJsonConverter))]
        public global::G.InitLiveKitRoomTransportProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitLiveKitRoomTransport" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public InitLiveKitRoomTransport(
            global::G.InitLiveKitRoomTransportProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitLiveKitRoomTransport" /> class.
        /// </summary>
        public InitLiveKitRoomTransport()
        {
        }
    }
}