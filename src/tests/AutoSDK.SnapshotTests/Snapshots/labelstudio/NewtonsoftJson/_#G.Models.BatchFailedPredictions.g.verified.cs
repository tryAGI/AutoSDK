//HintName: G.Models.BatchFailedPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchFailedPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> FailedPredictions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailedPredictions" /> class.
        /// </summary>
        /// <param name="failedPredictions"></param>
        /// <param name="jobId"></param>
        public BatchFailedPredictions(
            global::System.Collections.Generic.IList<object> failedPredictions,
            string jobId)
        {
            this.FailedPredictions = failedPredictions ?? throw new global::System.ArgumentNullException(nameof(failedPredictions));
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailedPredictions" /> class.
        /// </summary>
        public BatchFailedPredictions()
        {
        }
    }
}