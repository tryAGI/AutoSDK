//HintName: G.Models.BatchFailedPredictionsRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchFailedPredictionsRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> FailedPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelrun_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModelrunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailedPredictionsRequestRequest" /> class.
        /// </summary>
        /// <param name="failedPredictions"></param>
        /// <param name="modelrunId"></param>
        /// <param name="jobId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchFailedPredictionsRequestRequest(
            global::System.Collections.Generic.IList<object> failedPredictions,
            int modelrunId,
            string? jobId)
        {
            this.FailedPredictions = failedPredictions ?? throw new global::System.ArgumentNullException(nameof(failedPredictions));
            this.JobId = jobId;
            this.ModelrunId = modelrunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailedPredictionsRequestRequest" /> class.
        /// </summary>
        public BatchFailedPredictionsRequestRequest()
        {
        }
    }
}