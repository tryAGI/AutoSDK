//HintName: G.Models.ImportedAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for imported agents
    /// </summary>
    public sealed partial class ImportedAgentsResponse
    {
        /// <summary>
        /// List of IDs of the imported agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedAgentsResponse" /> class.
        /// </summary>
        /// <param name="agentIds">
        /// List of IDs of the imported agents
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportedAgentsResponse(
            global::System.Collections.Generic.IList<string> agentIds)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportedAgentsResponse" /> class.
        /// </summary>
        public ImportedAgentsResponse()
        {
        }
    }
}