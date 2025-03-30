//HintName: G.Models.DependentAvailableAgentToolIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependentAvailableAgentToolIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> UsedBy { get; set; } = default!;

        /// <summary>
        /// Default Value: available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DependentAvailableAgentToolIdentifierType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependentAvailableAgentToolIdentifierAccessLevel AccessLevel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableAgentToolIdentifier" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="usedBy"></param>
        /// <param name="type">
        /// Default Value: available
        /// </param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="accessLevel"></param>
        public DependentAvailableAgentToolIdentifier(
            string agentId,
            string agentName,
            global::System.Collections.Generic.IList<string> usedBy,
            int createdAtUnixSecs,
            global::G.DependentAvailableAgentToolIdentifierAccessLevel accessLevel,
            global::G.DependentAvailableAgentToolIdentifierType? type)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessLevel = accessLevel;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableAgentToolIdentifier" /> class.
        /// </summary>
        public DependentAvailableAgentToolIdentifier()
        {
        }
    }
}