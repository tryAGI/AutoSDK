//HintName: G.Models.UpdateClusterJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for updating a cluster job.
    /// </summary>
    public sealed partial class UpdateClusterJobResponse
    {
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
        /// Initializes a new instance of the <see cref="UpdateClusterJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        public UpdateClusterJobResponse(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClusterJobResponse" /> class.
        /// </summary>
        public UpdateClusterJobResponse()
        {
        }
    }
}