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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestCustomSttConfigProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentRequestCustomSttConfigProvider Provider { get; set; }

        /// <summary>
        /// Endpointing timeout in milliseconds. Minimum is 100 for azure, 10 for deepgram.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointing_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndpointingMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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