//HintName: G.Models.LettaServerRestApiRoutersV1AgentsCompactionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaServerRestApiRoutersV1AgentsCompactionRequest
    {
        /// <summary>
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_settings")]
        public global::G.CompactionSettingsInput? CompactionSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1AgentsCompactionRequest" /> class.
        /// </summary>
        /// <param name="compactionSettings">
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaServerRestApiRoutersV1AgentsCompactionRequest(
            global::G.CompactionSettingsInput? compactionSettings)
        {
            this.CompactionSettings = compactionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1AgentsCompactionRequest" /> class.
        /// </summary>
        public LettaServerRestApiRoutersV1AgentsCompactionRequest()
        {
        }
    }
}