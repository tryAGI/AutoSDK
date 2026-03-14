//HintName: G.Models.SessionArtifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Complete artifact information including metadata and optional base64-encoded content.<br/>
    /// Represents a file stored in an agent session workspace with all associated metadata.<br/>
    /// The `data` field contains the base64-encoded file content and is only included when<br/>
    /// fetching a single artifact, not in list responses.
    /// </summary>
    public sealed partial class SessionArtifact
    {
        /// <summary>
        /// Unique identifier for the artifact<br/>
        /// Example: art_report_pdf_a3f2
        /// </summary>
        /// <example>art_report_pdf_a3f2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactId { get; set; }

        /// <summary>
        /// Original filename of the artifact<br/>
        /// Example: report.pdf
        /// </summary>
        /// <example>report.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// MIME type of the file<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// File size in bytes<br/>
        /// Example: 2048576
        /// </summary>
        /// <example>2048576</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// SHA-256 checksum of the file content<br/>
        /// Example: a3f2b1c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2
        /// </summary>
        /// <example>a3f2b1c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum_sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChecksumSha256 { get; set; }

        /// <summary>
        /// Custom metadata associated with the artifact<br/>
        /// Example: {"original_filename":"report.pdf","source":"user_upload"}
        /// </summary>
        /// <example>{"original_filename":"report.pdf","source":"user_upload"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Optional description of the artifact<br/>
        /// Example: Q4 financial report
        /// </summary>
        /// <example>Q4 financial report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Time-to-live in days before the artifact is automatically deleted<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_days")]
        public int? TtlDays { get; set; }

        /// <summary>
        /// Timestamp when the artifact was created<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the artifact was last updated<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Base64-encoded file content (only included in single artifact fetch, not in list responses)<br/>
        /// Example: JVBERi0xLjQKJeLjz9MKMy4uLg==
        /// </summary>
        /// <example>JVBERi0xLjQKJeLjz9MKMy4uLg==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionArtifact" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// Unique identifier for the artifact<br/>
        /// Example: art_report_pdf_a3f2
        /// </param>
        /// <param name="filename">
        /// Original filename of the artifact<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="sizeBytes">
        /// File size in bytes<br/>
        /// Example: 2048576
        /// </param>
        /// <param name="checksumSha256">
        /// SHA-256 checksum of the file content<br/>
        /// Example: a3f2b1c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2
        /// </param>
        /// <param name="metadata">
        /// Custom metadata associated with the artifact<br/>
        /// Example: {"original_filename":"report.pdf","source":"user_upload"}
        /// </param>
        /// <param name="description">
        /// Optional description of the artifact<br/>
        /// Example: Q4 financial report
        /// </param>
        /// <param name="ttlDays">
        /// Time-to-live in days before the artifact is automatically deleted<br/>
        /// Example: 30
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the artifact was created<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the artifact was last updated<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="data">
        /// Base64-encoded file content (only included in single artifact fetch, not in list responses)<br/>
        /// Example: JVBERi0xLjQKJeLjz9MKMy4uLg==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionArtifact(
            string artifactId,
            string filename,
            string mimeType,
            long sizeBytes,
            string checksumSha256,
            object metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            int? ttlDays,
            byte[]? data)
        {
            this.ArtifactId = artifactId ?? throw new global::System.ArgumentNullException(nameof(artifactId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.ChecksumSha256 = checksumSha256 ?? throw new global::System.ArgumentNullException(nameof(checksumSha256));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.TtlDays = ttlDays;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionArtifact" /> class.
        /// </summary>
        public SessionArtifact()
        {
        }
    }
}