//HintName: G.Models.TranscriptReadyNotification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The notification when the transcript status is completed or error.
    /// </summary>
    public sealed partial class TranscriptReadyNotification
    {
        /// <summary>
        /// The ID of the transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TranscriptId { get; set; } = default!;

        /// <summary>
        /// The status of the transcript. Either completed or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranscriptReadyStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReadyNotification" /> class.
        /// </summary>
        /// <param name="transcriptId">
        /// The ID of the transcript
        /// </param>
        /// <param name="status">
        /// The status of the transcript. Either completed or error.
        /// </param>
        public TranscriptReadyNotification(
            global::System.Guid transcriptId,
            global::G.TranscriptReadyStatus status)
        {
            this.TranscriptId = transcriptId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReadyNotification" /> class.
        /// </summary>
        public TranscriptReadyNotification()
        {
        }
    }
}