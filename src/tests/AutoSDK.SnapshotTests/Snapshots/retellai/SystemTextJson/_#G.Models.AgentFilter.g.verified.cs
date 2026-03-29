//HintName: G.Models.AgentFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentFilter
    {
        /// <summary>
        /// The agent ID to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Specific versions to filter on. If not provided, all versions are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::System.Collections.Generic.IList<double>? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFilter" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent ID to filter on.
        /// </param>
        /// <param name="version">
        /// Specific versions to filter on. If not provided, all versions are included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentFilter(
            string agentId,
            global::System.Collections.Generic.IList<double>? version)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFilter" /> class.
        /// </summary>
        public AgentFilter()
        {
        }
    }
}