//HintName: G.Models.GetVideoResourceByJobIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVideoResourceByJobIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobId", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoResourceByJobIdRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="jobId"></param>
        public GetVideoResourceByJobIdRequest(
            global::System.Guid projectId,
            string jobId)
        {
            this.ProjectId = projectId;
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoResourceByJobIdRequest" /> class.
        /// </summary>
        public GetVideoResourceByJobIdRequest()
        {
        }
    }
}