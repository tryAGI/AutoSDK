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
        [global::Newtonsoft.Json.JsonProperty("artifact_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArtifactId { get; set; } = default!;

        /// <summary>
        /// Original filename of the artifact<br/>
        /// Example: report.pdf
        /// </summary>
        /// <example>report.pdf</example>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// MIME type of the file<br/>
        /// Example: application/pdf
        /// </summary>
        /// <example>application/pdf</example>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// File size in bytes<br/>
        /// Example: 2048576
        /// </summary>
        /// <example>2048576</example>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long SizeBytes { get; set; } = default!;

        /// <summary>
        /// SHA-256 checksum of the file content<br/>
        /// Example: a3f2b1c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2
        /// </summary>
        /// <example>a3f2b1c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2</example>
        [global::Newtonsoft.Json.JsonProperty("checksum_sha256", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChecksumSha256 { get; set; } = default!;

        /// <summary>
        /// Custom metadata associated with the artifact<br/>
        /// Example: {"original_filename":"report.pdf","source":"user_upload"}
        /// </summary>
        /// <example>{"original_filename":"report.pdf","source":"user_upload"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Optional description of the artifact<br/>
        /// Example: Q4 financial report
        /// </summary>
        /// <example>Q4 financial report</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Time-to-live in days before the artifact is automatically deleted<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("ttl_days")]
        public int? TtlDays { get; set; }

        /// <summary>
        /// Timestamp when the artifact was created<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the artifact was last updated<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Base64-encoded file content (only included in single artifact fetch, not in list responses)<br/>
        /// Example: JVBERi0xLjQKJeLjz9MKMy4uLg==
        /// </summary>
        /// <example>JVBERi0xLjQKJeLjz9MKMy4uLg==</example>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="createdAt">
        /// Timestamp when the artifact was created<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the artifact was last updated<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="description">
        /// Optional description of the artifact<br/>
        /// Example: Q4 financial report
        /// </param>
        /// <param name="ttlDays">
        /// Time-to-live in days before the artifact is automatically deleted<br/>
        /// Example: 30
        /// </param>
        /// <param name="data">
        /// Base64-encoded file content (only included in single artifact fetch, not in list responses)<br/>
        /// Example: JVBERi0xLjQKJeLjz9MKMy4uLg==
        /// </param>
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
            this.Description = description;
            this.TtlDays = ttlDays;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
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