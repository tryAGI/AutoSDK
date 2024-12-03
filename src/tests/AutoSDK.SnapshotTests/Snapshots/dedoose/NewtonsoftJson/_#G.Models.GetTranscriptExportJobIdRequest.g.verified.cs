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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TranscriptId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptExportJobIdRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="transcriptId"></param>
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