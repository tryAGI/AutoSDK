//HintName: G.Models.ParseConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse configuration schema.
    /// </summary>
    public sealed partial class ParseConfiguration
    {
        /// <summary>
        /// Unique identifier for the parse configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the parse configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Type of the source (e.g., 'project')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceType { get; set; } = default!;

        /// <summary>
        /// ID of the source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// Creator of the configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// Version of the configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// LlamaParseParameters configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LlamaParseParameters Parameters { get; set; } = default!;

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the parse configuration
        /// </param>
        /// <param name="name">
        /// Name of the parse configuration
        /// </param>
        /// <param name="sourceType">
        /// Type of the source (e.g., 'project')
        /// </param>
        /// <param name="sourceId">
        /// ID of the source
        /// </param>
        /// <param name="version">
        /// Version of the configuration
        /// </param>
        /// <param name="parameters">
        /// LlamaParseParameters configuration
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="creator">
        /// Creator of the configuration
        /// </param>
        public ParseConfiguration(
            string id,
            string name,
            string sourceType,
            string sourceId,
            string version,
            global::G.LlamaParseParameters parameters,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? creator)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType ?? throw new global::System.ArgumentNullException(nameof(sourceType));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Creator = creator;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfiguration" /> class.
        /// </summary>
        public ParseConfiguration()
        {
        }
    }
}