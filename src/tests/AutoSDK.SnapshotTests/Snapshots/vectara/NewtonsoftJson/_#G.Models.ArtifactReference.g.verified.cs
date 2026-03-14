//HintName: G.Models.ArtifactReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to an artifact stored in the agent session workspace.<br/>
    /// Artifacts are files or documents that belong to a specific agent session, providing a persistent workspace where agents and users can share files throughout a conversation. When users upload files (such as PDFs, Word documents, PowerPoint presentations, or images) to an agent session, these files are stored as artifacts that remain available for the duration of the session.<br/>
    /// **Session Binding**: Each artifact is scoped to a specific agent session and cannot be accessed from other sessions, ensuring data privacy and security.<br/>
    /// **Lifecycle**: Artifacts are created when users upload files via multipart requests or when agent tools generate new files (such as converting a PDF to markdown). Artifacts have a configurable time-to-live and are automatically removed when they expire or when the session is deleted. Size limits apply to individual artifacts and total session storage.<br/>
    /// **How Agents Use Artifacts**: Agent tools can read artifacts, process them, and create new derived artifacts. For example, the document conversion tool can take a PDF artifact, convert it to markdown, and store the result as a new artifact. This enables multi-step document processing workflows within a single session.<br/>
    /// **Common Use Cases**: Upload a document for the agent to analyze, provide multiple reference files for context, enable the agent to convert between formats, or allow the agent to generate and store processed files for later retrieval.
    /// </summary>
    public sealed partial class ArtifactReference
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReference" /> class.
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
        public ArtifactReference(
            string artifactId,
            string filename,
            string mimeType,
            long sizeBytes)
        {
            this.ArtifactId = artifactId ?? throw new global::System.ArgumentNullException(nameof(artifactId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReference" /> class.
        /// </summary>
        public ArtifactReference()
        {
        }
    }
}