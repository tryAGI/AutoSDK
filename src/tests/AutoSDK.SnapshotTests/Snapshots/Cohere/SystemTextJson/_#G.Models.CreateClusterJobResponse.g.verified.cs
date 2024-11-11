//HintName: G.Models.CreateClusterJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for creating a cluster job.
    /// </summary>
    public sealed partial class CreateClusterJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateClusterJobResponse(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClusterJobResponse" /> class.
        /// </summary>
        public CreateClusterJobResponse()
        {
        }
    }
}