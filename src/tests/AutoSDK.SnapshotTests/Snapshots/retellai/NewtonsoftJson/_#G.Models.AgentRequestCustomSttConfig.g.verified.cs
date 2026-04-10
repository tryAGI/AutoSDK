//HintName: G.Models.AgentRequestCustomSttConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom STT configuration. Only used when stt_mode is set to custom.
    /// </summary>
    public sealed partial class AgentRequestCustomSttConfig
    {
        /// <summary>
        /// The STT provider to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentRequestCustomSttConfigProviderJsonConverter))]
        public global::G.AgentRequestCustomSttConfigProvider Provider { get; set; } = default!;

        /// <summary>
        /// Endpointing timeout in milliseconds. Minimum is 100 for azure, 10 for deepgram.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointing_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndpointingMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestCustomSttConfig" /> class.
        /// </summary>
        /// <param name="provider">
        /// The STT provider to use.
        /// </param>
        /// <param name="endpointingMs">
        /// Endpointing timeout in milliseconds. Minimum is 100 for azure, 10 for deepgram.
        /// </param>
        public AgentRequestCustomSttConfig(
            global::G.AgentRequestCustomSttConfigProvider provider,
            int endpointingMs)
        {
            this.Provider = provider;
            this.EndpointingMs = endpointingMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestCustomSttConfig" /> class.
        /// </summary>
        public AgentRequestCustomSttConfig()
        {
        }
    }
}