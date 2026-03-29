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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Default Value: {"manager_type":"round_robin"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManagerConfig3JsonConverter))]
        public global::G.ManagerConfig3? ManagerConfig { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SharedBlockIds { get; set; }

        /// <summary>
        /// If set to True, the group will be hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The id of the base template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseTemplateId { get; set; }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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