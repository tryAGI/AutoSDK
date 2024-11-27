//HintName: G.Models.AddTranscriptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTranscriptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentUserId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptData", Required = global::Newtonsoft.Json.Required.Always)]
        public string TranscriptData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTranscriptRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="resourceId"></param>
        /// <param name="transcriptData"></param>
        public AddTranscriptRequest(
            global::System.Guid projectId,
            global::System.Guid currentUserId,
            global::System.Guid resourceId,
            string transcriptData)
        {
            this.ProjectId = projectId;
            this.CurrentUserId = currentUserId;
            this.ResourceId = resourceId;
            this.TranscriptData = transcriptData ?? throw new global::System.ArgumentNullException(nameof(transcriptData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTranscriptRequest" /> class.
        /// </summary>
        public AddTranscriptRequest()
        {
        }
    }
}