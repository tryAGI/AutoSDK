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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// List of errors that occurred during ingestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Name of the job that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobNameMappingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobNameMapping Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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