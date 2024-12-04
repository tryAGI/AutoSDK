//HintName: G.Models.RealtimeServerEventResponseAudioDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated audio is updated.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseAudioDelta
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.audio.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseAudioDeltaType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

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
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// Base64-encoded audio data delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.audio.delta`.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        /// <param name="delta">
        /// Base64-encoded audio data delta.
        /// </param>
        public RealtimeServerEventResponseAudioDelta(
            string eventId,
            string responseId,
            string itemId,
            int outputIndex,
            int contentIndex,
            string delta,
            global::G.RealtimeServerEventResponseAudioDeltaType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseAudioDelta" /> class.
        /// </summary>
        public RealtimeServerEventResponseAudioDelta()
        {
        }
    }
}