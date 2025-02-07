//HintName: G.Models.GetDesDataFromFileJobResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDesDataFromFileJobResultRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDesDataFromFileJobResultRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDesDataFromFileJobResultRequest(
            global::System.Guid jobId)
        {
            this.JobId = jobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDesDataFromFileJobResultRequest" /> class.
        /// </summary>
        public GetDesDataFromFileJobResultRequest()
        {
        }
    }
}