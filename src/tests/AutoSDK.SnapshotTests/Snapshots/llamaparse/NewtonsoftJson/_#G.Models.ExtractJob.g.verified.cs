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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The agent that the job was run on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_agent", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractAgent ExtractionAgent { get; set; } = default!;

        /// <summary>
        /// The status of the extraction job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The error that occurred during extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The id of the file that the extract was extracted from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that the extract was extracted from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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