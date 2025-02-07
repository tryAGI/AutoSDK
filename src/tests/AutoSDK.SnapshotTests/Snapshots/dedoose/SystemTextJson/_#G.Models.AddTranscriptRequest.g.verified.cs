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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CurrentUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTranscriptRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="resourceId"></param>
        /// <param name="transcriptData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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