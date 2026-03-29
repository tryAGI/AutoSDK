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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceType { get; set; }

        /// <summary>
        /// ID of the source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

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
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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