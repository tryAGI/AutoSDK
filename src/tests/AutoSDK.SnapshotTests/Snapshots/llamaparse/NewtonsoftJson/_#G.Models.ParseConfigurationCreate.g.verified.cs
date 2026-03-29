//HintName: G.Models.ParseConfigurationCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a new parse configuration (API boundary).
    /// </summary>
    public sealed partial class ParseConfigurationCreate
    {
        /// <summary>
        /// Name of the parse configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Type of the source (e.g., 'project')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// ID of the source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id")]
        public string? SourceId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfigurationCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the parse configuration
        /// </param>
        /// <param name="version">
        /// Version of the configuration
        /// </param>
        /// <param name="parameters">
        /// LlamaParseParameters configuration
        /// </param>
        /// <param name="sourceType">
        /// Type of the source (e.g., 'project')
        /// </param>
        /// <param name="sourceId">
        /// ID of the source
        /// </param>
        /// <param name="creator">
        /// Creator of the configuration
        /// </param>
        public ParseConfigurationCreate(
            string name,
            string version,
            global::G.LlamaParseParameters parameters,
            string? sourceType,
            string? sourceId,
            string? creator)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceType = sourceType;
            this.SourceId = sourceId;
            this.Creator = creator;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfigurationCreate" /> class.
        /// </summary>
        public ParseConfigurationCreate()
        {
        }
    }
}