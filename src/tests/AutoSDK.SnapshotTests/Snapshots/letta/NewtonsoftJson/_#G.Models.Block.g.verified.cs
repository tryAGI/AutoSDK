//HintName: G.Models.Block.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Block represents a reserved section of the LLM's context window.
    /// </summary>
    public sealed partial class Block
    {
        /// <summary>
        /// Value of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Character limit of the block.<br/>
        /// Default Value: 100000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Name of the block if it is a template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_name")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// Whether the block is a template (e.g. saved human/persona options).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template id of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// The id of the entity within the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Preserve the block on template migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_on_migration")]
        public bool? PreserveOnMigration { get; set; }

        /// <summary>
        /// Label of the block (e.g. 'human', 'persona') in the context window.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Whether the agent has read-only access to the block.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Description of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata of the block.<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// If set to True, the block will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The human-friendly ID of the Block
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The id of the user that made this Block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that last updated this Block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The tags associated with the block.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of the block.
        /// </param>
        /// <param name="limit">
        /// Character limit of the block.<br/>
        /// Default Value: 100000
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="templateName">
        /// Name of the block if it is a template.
        /// </param>
        /// <param name="isTemplate">
        /// Whether the block is a template (e.g. saved human/persona options).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id of the block.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="entityId">
        /// The id of the entity within the template.
        /// </param>
        /// <param name="preserveOnMigration">
        /// Preserve the block on template migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="label">
        /// Label of the block (e.g. 'human', 'persona') in the context window.
        /// </param>
        /// <param name="readOnly">
        /// Whether the agent has read-only access to the block.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Description of the block.
        /// </param>
        /// <param name="metadata">
        /// Metadata of the block.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="hidden">
        /// If set to True, the block will be hidden.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Block
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this Block.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that last updated this Block.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the block.<br/>
        /// Default Value: []
        /// </param>
        public Block(
            string value,
            int? limit,
            string? projectId,
            string? templateName,
            bool? isTemplate,
            string? templateId,
            string? baseTemplateId,
            string? deploymentId,
            string? entityId,
            bool? preserveOnMigration,
            string? label,
            bool? readOnly,
            string? description,
            object? metadata,
            bool? hidden,
            string? id,
            string? createdById,
            string? lastUpdatedById,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Limit = limit;
            this.ProjectId = projectId;
            this.TemplateName = templateName;
            this.IsTemplate = isTemplate;
            this.TemplateId = templateId;
            this.BaseTemplateId = baseTemplateId;
            this.DeploymentId = deploymentId;
            this.EntityId = entityId;
            this.PreserveOnMigration = preserveOnMigration;
            this.Label = label;
            this.ReadOnly = readOnly;
            this.Description = description;
            this.Metadata = metadata;
            this.Hidden = hidden;
            this.Id = id;
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        public Block()
        {
        }
    }
}