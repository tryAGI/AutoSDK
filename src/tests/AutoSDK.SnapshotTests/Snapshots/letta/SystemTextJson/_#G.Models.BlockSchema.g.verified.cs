//HintName: G.Models.BlockSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Block with human-readable ID for agent file
    /// </summary>
    public sealed partial class BlockSchema
    {
        /// <summary>
        /// Value of the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Character limit of the block.<br/>
        /// Default Value: 100000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The associated project id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Name of the block if it is a template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template id of the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// The id of the entity within the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Preserve the block on template migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_on_migration")]
        public bool? PreserveOnMigration { get; set; }

        /// <summary>
        /// Label of the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Whether the agent has read-only access to the block.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Description of the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata of the block.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// If set to True, the block will be hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The tags to associate with the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Human-readable identifier for this block in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockSchema" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of the block.
        /// </param>
        /// <param name="label">
        /// Label of the block.
        /// </param>
        /// <param name="id">
        /// Human-readable identifier for this block in the file
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
        /// <param name="tags">
        /// The tags to associate with the block.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlockSchema(
            string value,
            string label,
            string id,
            int? limit,
            string? projectId,
            string? templateName,
            bool? isTemplate,
            string? templateId,
            string? baseTemplateId,
            string? deploymentId,
            string? entityId,
            bool? preserveOnMigration,
            bool? readOnly,
            string? description,
            object? metadata,
            bool? hidden,
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
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ReadOnly = readOnly;
            this.Description = description;
            this.Metadata = metadata;
            this.Hidden = hidden;
            this.Tags = tags;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockSchema" /> class.
        /// </summary>
        public BlockSchema()
        {
        }
    }
}