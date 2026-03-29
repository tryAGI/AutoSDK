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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// When the version was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Version description message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Whether this is the latest version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLatest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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