//HintName: G.Models.TemplatesListTemplateVersionsResponseVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesListTemplateVersionsResponseVersion
    {
        /// <summary>
        /// The version number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// When the version was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Version description message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Whether this is the latest version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_latest", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLatest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponseVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// The version number
        /// </param>
        /// <param name="createdAt">
        /// When the version was created
        /// </param>
        /// <param name="isLatest">
        /// Whether this is the latest version
        /// </param>
        /// <param name="message">
        /// Version description message
        /// </param>
        public TemplatesListTemplateVersionsResponseVersion(
            string version,
            string createdAt,
            bool isLatest,
            string? message)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Message = message;
            this.IsLatest = isLatest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponseVersion" /> class.
        /// </summary>
        public TemplatesListTemplateVersionsResponseVersion()
        {
        }
    }
}