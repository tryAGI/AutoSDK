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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the source (e.g., 'project')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// ID of the source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// Creator of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// Version of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// LlamaParseParameters configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LlamaParseParameters Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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