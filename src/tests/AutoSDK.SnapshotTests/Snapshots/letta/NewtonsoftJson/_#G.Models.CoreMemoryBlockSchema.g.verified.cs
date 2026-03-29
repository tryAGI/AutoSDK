//HintName: G.Models.CoreMemoryBlockSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoreMemoryBlockSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_template", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_name")]
        public string? TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreMemoryBlockSchema" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="isTemplate"></param>
        /// <param name="label"></param>
        /// <param name="limit"></param>
        /// <param name="updatedAt"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="templateName"></param>
        public CoreMemoryBlockSchema(
            string createdAt,
            bool isTemplate,
            string label,
            int limit,
            string updatedAt,
            string value,
            string? description,
            object? metadata,
            string? templateName)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description;
            this.IsTemplate = isTemplate;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Limit = limit;
            this.Metadata = metadata;
            this.TemplateName = templateName;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreMemoryBlockSchema" /> class.
        /// </summary>
        public CoreMemoryBlockSchema()
        {
        }
    }
}