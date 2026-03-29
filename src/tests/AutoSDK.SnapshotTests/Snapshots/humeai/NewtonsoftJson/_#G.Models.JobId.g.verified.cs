//HintName: G.Models.JobId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobId" /> class.
        /// </summary>
        /// <param name="jobId1"></param>
        public JobId(
            string? jobId1)
        {
            this.JobId1 = jobId1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobId" /> class.
        /// </summary>
        public JobId()
        {
        }
    }
}