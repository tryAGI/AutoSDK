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
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Specific versions to filter on. If not provided, all versions are included.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public global::System.Collections.Generic.IList<double>? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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