//HintName: G.Models.RealtimeServerEventResponseAudioTranscriptDone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated transcription of audio output is done<br/>
    /// streaming. Also emitted when a Response is interrupted, incomplete, or<br/>
    /// cancelled.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseAudioTranscriptDone
    {
        /// <summary>
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// The final transcript of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.audio_transcript.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseAudioTranscriptDoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioTranscriptDone" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="transcript">
        /// The final transcript of the audio.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.audio_transcript.done`.
        /// </param>
        public RealtimeServerEventResponseAudioTranscriptDone(
            int contentIndex,
            string eventId,
            string itemId,
            int outputIndex,
            string responseId,
            string transcript,
            global::G.RealtimeServerEventResponseAudioTranscriptDoneType type)
        {
            this.ContentIndex = contentIndex;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioTranscriptDone" /> class.
        /// </summary>
        public RealtimeServerEventResponseAudioTranscriptDone()
        {
        }
    }
}