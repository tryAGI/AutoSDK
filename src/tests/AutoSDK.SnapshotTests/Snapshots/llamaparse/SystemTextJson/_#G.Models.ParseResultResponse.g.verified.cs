//HintName: G.Models.ParseResultResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parse result response with job status and optional content or metadata.<br/>
    /// The job field is always included. Other fields are included based on expand parameters.
    /// </summary>
    public sealed partial class ParseResultResponse
    {
        /// <summary>
        /// Parse job status and metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ParseJobResponse Job { get; set; }

        /// <summary>
        /// Metadata including size, existence, and presigned URLs for result files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_content_metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ResultTypeMetadata>? ResultContentMetadata { get; set; }

        /// <summary>
        /// Plain text result (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::G.TextResult? Text { get; set; }

        /// <summary>
        /// Markdown result (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public global::G.MarkdownResult? Markdown { get; set; }

        /// <summary>
        /// Structured JSON result (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::G.StructuredResult? Items { get; set; }

        /// <summary>
        /// Page-level metadata including confidence scores and presentation data (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.MetadataResult? Metadata { get; set; }

        /// <summary>
        /// Full raw markdown content (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_full")]
        public string? MarkdownFull { get; set; }

        /// <summary>
        /// Full raw text content (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_full")]
        public string? TextFull { get; set; }

        /// <summary>
        /// Metadata for all extracted images with presigned URLs (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images_content_metadata")]
        public global::G.ImagesContentMetadata? ImagesContentMetadata { get; set; }

        /// <summary>
        /// Job execution metadata (if requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_metadata")]
        public object? JobMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_parameters")]
        public object? RawParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResultResponse" /> class.
        /// </summary>
        /// <param name="job">
        /// Parse job status and metadata
        /// </param>
        /// <param name="resultContentMetadata">
        /// Metadata including size, existence, and presigned URLs for result files
        /// </param>
        /// <param name="text">
        /// Plain text result (if requested)
        /// </param>
        /// <param name="markdown">
        /// Markdown result (if requested)
        /// </param>
        /// <param name="items">
        /// Structured JSON result (if requested)
        /// </param>
        /// <param name="metadata">
        /// Page-level metadata including confidence scores and presentation data (if requested)
        /// </param>
        /// <param name="markdownFull">
        /// Full raw markdown content (if requested)
        /// </param>
        /// <param name="textFull">
        /// Full raw text content (if requested)
        /// </param>
        /// <param name="imagesContentMetadata">
        /// Metadata for all extracted images with presigned URLs (if requested)
        /// </param>
        /// <param name="jobMetadata">
        /// Job execution metadata (if requested)
        /// </param>
        /// <param name="rawParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseResultResponse(
            global::G.ParseJobResponse job,
            global::System.Collections.Generic.Dictionary<string, global::G.ResultTypeMetadata>? resultContentMetadata,
            global::G.TextResult? text,
            global::G.MarkdownResult? markdown,
            global::G.StructuredResult? items,
            global::G.MetadataResult? metadata,
            string? markdownFull,
            string? textFull,
            global::G.ImagesContentMetadata? imagesContentMetadata,
            object? jobMetadata,
            object? rawParameters)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.ResultContentMetadata = resultContentMetadata;
            this.Text = text;
            this.Markdown = markdown;
            this.Items = items;
            this.Metadata = metadata;
            this.MarkdownFull = markdownFull;
            this.TextFull = textFull;
            this.ImagesContentMetadata = imagesContentMetadata;
            this.JobMetadata = jobMetadata;
            this.RawParameters = rawParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResultResponse" /> class.
        /// </summary>
        public ParseResultResponse()
        {
        }
    }
}