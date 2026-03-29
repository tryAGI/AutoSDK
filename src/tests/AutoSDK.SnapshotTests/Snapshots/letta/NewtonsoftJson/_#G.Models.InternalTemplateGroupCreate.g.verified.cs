//HintName: G.Models.InternalTemplateGroupCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Used for Letta Cloud
    /// </summary>
    public sealed partial class InternalTemplateGroupCreate
    {
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
        /// Default Value: {"manager_type":"round_robin"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_config")]
        public global::G.ManagerConfig3? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shared_block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The id of the base template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseTemplateId { get; set; } = default!;

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreate" /> class.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="baseTemplateId">
        /// The id of the base template.
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
        public InternalTemplateGroupCreate(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string baseTemplateId,
            string templateId,
            string deploymentId,
            global::G.ManagerConfig3? managerConfig,
            string? projectId,
            bool? hidden)
        {
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ManagerConfig = managerConfig;
            this.ProjectId = projectId;
            this.Hidden = hidden;
            this.BaseTemplateId = baseTemplateId ?? throw new global::System.ArgumentNullException(nameof(baseTemplateId));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreate" /> class.
        /// </summary>
        public InternalTemplateGroupCreate()
        {
        }
    }
}