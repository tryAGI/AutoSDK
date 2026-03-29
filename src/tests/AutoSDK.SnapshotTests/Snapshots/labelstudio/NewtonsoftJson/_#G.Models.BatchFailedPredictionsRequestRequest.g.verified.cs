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
        [global::Newtonsoft.Json.JsonProperty("failed_predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> FailedPredictions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelrun_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ModelrunId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailedPredictionsRequestRequest" /> class.
        /// </summary>
        /// <param name="failedPredictions"></param>
        /// <param name="modelrunId"></param>
        /// <param name="jobId"></param>
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