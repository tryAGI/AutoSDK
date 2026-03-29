//HintName: G.Models.IngestionErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestionErrorResponse
    {
        /// <summary>
        /// ID of the job that failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid JobId { get; set; } = default!;

        /// <summary>
        /// List of errors that occurred during ingestion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Name of the job that failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobNameMapping Step { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionErrorResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// ID of the job that failed.
        /// </param>
        /// <param name="message">
        /// List of errors that occurred during ingestion.
        /// </param>
        /// <param name="step">
        /// Name of the job that failed.
        /// </param>
        public IngestionErrorResponse(
            global::System.Guid jobId,
            string message,
            global::G.JobNameMapping step)
        {
            this.JobId = jobId;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionErrorResponse" /> class.
        /// </summary>
        public IngestionErrorResponse()
        {
        }
    }
}