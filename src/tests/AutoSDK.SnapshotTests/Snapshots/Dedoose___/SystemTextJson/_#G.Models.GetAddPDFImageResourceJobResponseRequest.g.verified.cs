//HintName: G.Models.GetAddPDFImageResourceJobResponseRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAddPDFImageResourceJobResponseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddPDFImageResourceJobResponseRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetAddPDFImageResourceJobResponseRequest(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddPDFImageResourceJobResponseRequest" /> class.
        /// </summary>
        public GetAddPDFImageResourceJobResponseRequest()
        {
        }
    }
}