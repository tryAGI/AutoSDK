//HintName: G.Models.Group.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Group
    {
        /// <summary>
        /// The id of the group. Assigned by the database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ManagerType ManagerType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AgentIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shared_block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("termination_token")]
        public string? TerminationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sleeptime_agent_frequency")]
        public int? SleeptimeAgentFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turns_counter")]
        public int? TurnsCounter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_processed_message_id")]
        public string? LastProcessedMessageId { get; set; }

        /// <summary>
        /// The desired maximum length of messages in the context window of the convo agent. This is a best effort, and may be off slightly due to user/assistant interleaving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_message_buffer_length")]
        public int? MaxMessageBufferLength { get; set; }

        /// <summary>
        /// The desired minimum length of messages in the context window of the convo agent. This is a best effort, and may be off-by-one due to user/assistant interleaving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_message_buffer_length")]
        public int? MinMessageBufferLength { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the group. Assigned by the database.
        /// </param>
        /// <param name="managerType"></param>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="managerAgentId"></param>
        /// <param name="terminationToken"></param>
        /// <param name="maxTurns"></param>
        /// <param name="sleeptimeAgentFrequency"></param>
        /// <param name="turnsCounter"></param>
        /// <param name="lastProcessedMessageId"></param>
        /// <param name="maxMessageBufferLength">
        /// The desired maximum length of messages in the context window of the convo agent. This is a best effort, and may be off slightly due to user/assistant interleaving.
        /// </param>
        /// <param name="minMessageBufferLength">
        /// The desired minimum length of messages in the context window of the convo agent. This is a best effort, and may be off-by-one due to user/assistant interleaving.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
        public Group(
            string id,
            global::G.ManagerType managerType,
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string? projectId,
            string? templateId,
            string? baseTemplateId,
            string? deploymentId,
            string? managerAgentId,
            string? terminationToken,
            int? maxTurns,
            int? sleeptimeAgentFrequency,
            int? turnsCounter,
            string? lastProcessedMessageId,
            int? maxMessageBufferLength,
            int? minMessageBufferLength,
            bool? hidden)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ManagerType = managerType;
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ProjectId = projectId;
            this.TemplateId = templateId;
            this.BaseTemplateId = baseTemplateId;
            this.DeploymentId = deploymentId;
            this.ManagerAgentId = managerAgentId;
            this.TerminationToken = terminationToken;
            this.MaxTurns = maxTurns;
            this.SleeptimeAgentFrequency = sleeptimeAgentFrequency;
            this.TurnsCounter = turnsCounter;
            this.LastProcessedMessageId = lastProcessedMessageId;
            this.MaxMessageBufferLength = maxMessageBufferLength;
            this.MinMessageBufferLength = minMessageBufferLength;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        public Group()
        {
        }
    }
}