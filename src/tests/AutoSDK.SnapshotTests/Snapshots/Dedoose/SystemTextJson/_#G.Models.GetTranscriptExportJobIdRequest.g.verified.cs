//HintName: G.Models.GetTranscriptExportJobIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranscriptExportJobIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TranscriptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptExportJobIdRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="transcriptId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTranscriptExportJobIdRequest(
            global::System.Guid projectId,
            global::System.Guid transcriptId)
        {
            this.ProjectId = projectId;
            this.TranscriptId = transcriptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptExportJobIdRequest" /> class.
        /// </summary>
        public GetTranscriptExportJobIdRequest()
        {
        }
    }
}