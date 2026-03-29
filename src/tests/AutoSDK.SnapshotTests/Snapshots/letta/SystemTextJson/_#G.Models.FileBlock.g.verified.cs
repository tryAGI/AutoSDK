//HintName: G.Models.FileBlock.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileBlock
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
        /// Whether the block is a template (e.g. saved human/persona options).<br/>
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
        /// Label of the block (e.g. 'human', 'persona') in the context window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        /// The human-friendly ID of the Block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The id of the user that made this Block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that last updated this Block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The tags associated with the block.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Unique identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// True if the agent currently has the file open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOpen { get; set; }

        /// <summary>
        /// UTC timestamp of the agent’s most recent access to this file. Any operations from the open, close, or search tools will update this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileBlock" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of the block.
        /// </param>
        /// <param name="fileId">
        /// Unique identifier of the file.
        /// </param>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source.
        /// </param>
        /// <param name="isOpen">
        /// True if the agent currently has the file open.
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
        /// <param name="lastAccessedAt">
        /// UTC timestamp of the agent’s most recent access to this file. Any operations from the open, close, or search tools will update this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileBlock(
            string value,
            string fileId,
            string sourceId,
            bool isOpen,
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
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? lastAccessedAt)
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
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.IsOpen = isOpen;
            this.LastAccessedAt = lastAccessedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileBlock" /> class.
        /// </summary>
        public FileBlock()
        {
        }
    }
}