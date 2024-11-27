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
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceTranscript Transcript { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptData", Required = global::Newtonsoft.Json.Required.Always)]
        public string TranscriptData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("syncItems", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> SyncItems { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTranscriptDataRequest" /> class.
        /// </summary>
        /// <param name="transcript"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
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