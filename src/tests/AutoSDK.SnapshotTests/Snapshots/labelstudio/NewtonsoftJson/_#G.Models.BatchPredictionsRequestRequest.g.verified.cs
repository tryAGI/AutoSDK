//HintName: G.Models.BatchPredictionsRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchPredictionsRequestRequest
    {
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPredictionsRequestRequest" /> class.
        /// </summary>
        /// <param name="modelrunId"></param>
        /// <param name="results"></param>
        /// <param name="jobId"></param>
        public BatchPredictionsRequestRequest(
            int modelrunId,
            global::System.Collections.Generic.IList<object> results,
            string? jobId)
        {
            this.JobId = jobId;
            this.ModelrunId = modelrunId;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchPredictionsRequestRequest" /> class.
        /// </summary>
        public BatchPredictionsRequestRequest()
        {
        }
    }
}