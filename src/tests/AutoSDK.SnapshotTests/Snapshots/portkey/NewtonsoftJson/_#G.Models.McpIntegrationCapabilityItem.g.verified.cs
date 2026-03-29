//HintName: G.Models.McpIntegrationCapabilityItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilityItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.McpIntegrationCapabilityItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icons")]
        public byte[]? Icons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution")]
        public object? Execution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public byte[]? Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri_template")]
        public string? UriTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilityItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="icons"></param>
        /// <param name="enabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="inputSchema"></param>
        /// <param name="outputSchema"></param>
        /// <param name="execution"></param>
        /// <param name="annotations"></param>
        /// <param name="arguments"></param>
        /// <param name="uri"></param>
        /// <param name="uriTemplate"></param>
        /// <param name="mimeType"></param>
        /// <param name="size"></param>
        public McpIntegrationCapabilityItem(
            string? name,
            global::G.McpIntegrationCapabilityItemType? type,
            string? title,
            string? description,
            byte[]? icons,
            bool? enabled,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            object? inputSchema,
            object? outputSchema,
            object? execution,
            object? annotations,
            byte[]? arguments,
            string? uri,
            string? uriTemplate,
            string? mimeType,
            double? size)
        {
            this.Name = name;
            this.Type = type;
            this.Title = title;
            this.Description = description;
            this.Icons = icons;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
            this.Execution = execution;
            this.Annotations = annotations;
            this.Arguments = arguments;
            this.Uri = uri;
            this.UriTemplate = uriTemplate;
            this.MimeType = mimeType;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilityItem" /> class.
        /// </summary>
        public McpIntegrationCapabilityItem()
        {
        }
    }
}