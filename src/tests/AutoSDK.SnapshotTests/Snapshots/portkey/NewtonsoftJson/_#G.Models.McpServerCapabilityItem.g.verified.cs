//HintName: G.Models.McpServerCapabilityItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerCapabilityItem
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
        public global::G.McpServerCapabilityItemType? Type { get; set; }

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
        /// Present for service users; indicates integration-level enabled state
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_enabled")]
        public bool? IntegrationEnabled { get; set; }

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
        /// Initializes a new instance of the <see cref="McpServerCapabilityItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="icons"></param>
        /// <param name="enabled"></param>
        /// <param name="integrationEnabled">
        /// Present for service users; indicates integration-level enabled state
        /// </param>
        /// <param name="inputSchema"></param>
        /// <param name="outputSchema"></param>
        /// <param name="execution"></param>
        /// <param name="annotations"></param>
        /// <param name="arguments"></param>
        /// <param name="uri"></param>
        /// <param name="uriTemplate"></param>
        /// <param name="mimeType"></param>
        /// <param name="size"></param>
        public McpServerCapabilityItem(
            string? name,
            global::G.McpServerCapabilityItemType? type,
            string? title,
            string? description,
            byte[]? icons,
            bool? enabled,
            bool? integrationEnabled,
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
            this.IntegrationEnabled = integrationEnabled;
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
        /// Initializes a new instance of the <see cref="McpServerCapabilityItem" /> class.
        /// </summary>
        public McpServerCapabilityItem()
        {
        }
    }
}