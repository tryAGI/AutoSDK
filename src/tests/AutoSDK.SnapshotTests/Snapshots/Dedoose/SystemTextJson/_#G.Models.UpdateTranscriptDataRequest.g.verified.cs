//HintName: G.Models.UpdateTranscriptDataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTranscriptDataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResourceTranscript Transcript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> SyncItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTranscriptDataRequest" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateTranscriptDataRequest(
            global::G.ResourceTranscript transcript,
            string transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> syncItems)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.TranscriptData = transcriptData ?? throw new global::System.ArgumentNullException(nameof(transcriptData));
            this.SyncItems = syncItems ?? throw new global::System.ArgumentNullException(nameof(syncItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTranscriptDataRequest" /> class.
        /// </summary>
        public UpdateTranscriptDataRequest()
        {
        }
    }
}