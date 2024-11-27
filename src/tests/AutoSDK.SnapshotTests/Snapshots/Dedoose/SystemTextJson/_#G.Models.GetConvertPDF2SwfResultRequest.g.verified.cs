//HintName: G.Models.GetConvertPDF2SwfResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConvertPDF2SwfResultRequest
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
        /// Initializes a new instance of the <see cref="GetConvertPDF2SwfResultRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetConvertPDF2SwfResultRequest(
            global::System.Guid jobId)
        {
            this.JobId = jobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvertPDF2SwfResultRequest" /> class.
        /// </summary>
        public GetConvertPDF2SwfResultRequest()
        {
        }
    }
}