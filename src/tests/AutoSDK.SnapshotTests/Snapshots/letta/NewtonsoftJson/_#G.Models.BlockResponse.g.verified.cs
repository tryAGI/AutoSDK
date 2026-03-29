//HintName: G.Models.BlockResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlockResponse
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
        /// (Deprecated) The name of the block template (if it is a template).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// Whether the block is a template (e.g. saved human/persona options).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// (Deprecated) The id of the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// (Deprecated) The base template id of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// (Deprecated) The id of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// (Deprecated) The id of the entity within the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EntityId { get; set; }

        /// <summary>
        /// (Deprecated) Preserve the block on template migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_on_migration")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PreserveOnMigration { get; set; }

        /// <summary>
        /// Label of the block (e.g. 'human', 'persona') in the context window.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// (Deprecated) Whether the agent has read-only access to the block.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// (Deprecated) If set to True, the block will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The id of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        /// <param name="value">
        /// Value of the block.
        /// </param>
        /// <param name="id">
        /// The id of the block.
        /// </param>
        /// <param name="limit">
        /// Character limit of the block.<br/>
        /// Default Value: 100000
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="isTemplate">
        /// Whether the block is a template (e.g. saved human/persona options).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="label">
        /// Label of the block (e.g. 'human', 'persona') in the context window.
        /// </param>
        /// <param name="description">
        /// Description of the block.
        /// </param>
        /// <param name="metadata">
        /// Metadata of the block.<br/>
        /// Default Value: {}
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
        public BlockResponse(
            string value,
            string id,
            int? limit,
            string? projectId,
            bool? isTemplate,
            string? label,
            string? description,
            object? metadata,
            string? createdById,
            string? lastUpdatedById,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Limit = limit;
            this.ProjectId = projectId;
            this.IsTemplate = isTemplate;
            this.Label = label;
            this.Description = description;
            this.Metadata = metadata;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        public BlockResponse()
        {
        }
    }
}