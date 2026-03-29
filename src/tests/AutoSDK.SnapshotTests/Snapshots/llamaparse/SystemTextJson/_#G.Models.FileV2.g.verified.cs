//HintName: G.Models.FileV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An uploaded file.
    /// </summary>
    public sealed partial class FileV2
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// File name including extension
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional ID for correlating with an external system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// File extension (pdf, docx, png, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// Project this file belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// When the file was last modified (ISO 8601)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified_at")]
        public global::System.DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// When the file expires and may be automatically removed. Null means no expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// How the file will be used: user_data, parse, extract, classify, split, sheet, or agent_app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileV2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique file identifier
        /// </param>
        /// <param name="name">
        /// File name including extension
        /// </param>
        /// <param name="projectId">
        /// Project this file belongs to
        /// </param>
        /// <param name="externalFileId">
        /// Optional ID for correlating with an external system
        /// </param>
        /// <param name="fileType">
        /// File extension (pdf, docx, png, etc.)
        /// </param>
        /// <param name="lastModifiedAt">
        /// When the file was last modified (ISO 8601)
        /// </param>
        /// <param name="expiresAt">
        /// When the file expires and may be automatically removed. Null means no expiration.
        /// </param>
        /// <param name="purpose">
        /// How the file will be used: user_data, parse, extract, classify, split, sheet, or agent_app
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileV2(
            string id,
            string name,
            global::System.Guid projectId,
            string? externalFileId,
            string? fileType,
            global::System.DateTime? lastModifiedAt,
            global::System.DateTime? expiresAt,
            string? purpose)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExternalFileId = externalFileId;
            this.FileType = fileType;
            this.ProjectId = projectId;
            this.LastModifiedAt = lastModifiedAt;
            this.ExpiresAt = expiresAt;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileV2" /> class.
        /// </summary>
        public FileV2()
        {
        }
    }
}