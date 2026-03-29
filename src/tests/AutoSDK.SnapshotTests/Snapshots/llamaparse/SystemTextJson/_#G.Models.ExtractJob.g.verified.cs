//HintName: G.Models.ExtractJob.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for an extraction job.
    /// </summary>
    public sealed partial class ExtractJob
    {
        /// <summary>
        /// The id of the extraction job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The agent that the job was run on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractAgent ExtractionAgent { get; set; }

        /// <summary>
        /// The status of the extraction job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtractJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractJobStatus Status { get; set; }

        /// <summary>
        /// The error that occurred during extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The id of the file that the extract was extracted from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that the extract was extracted from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the extraction job
        /// </param>
        /// <param name="extractionAgent">
        /// The agent that the job was run on.
        /// </param>
        /// <param name="status">
        /// The status of the extraction job
        /// </param>
        /// <param name="error">
        /// The error that occurred during extraction
        /// </param>
        /// <param name="fileId">
        /// The id of the file that the extract was extracted from
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractJob(
            global::System.Guid id,
            global::G.ExtractAgent extractionAgent,
            global::G.ExtractJobStatus status,
            string? error,
            global::System.Guid? fileId)
        {
            this.Id = id;
            this.ExtractionAgent = extractionAgent ?? throw new global::System.ArgumentNullException(nameof(extractionAgent));
            this.Status = status;
            this.Error = error;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJob" /> class.
        /// </summary>
        public ExtractJob()
        {
        }
    }
}