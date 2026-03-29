//HintName: G.Models.StreamTextResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains a fragment of generated text. Note that text fragments may be split at arbitrary points, not necessarily at word or sentence boundaries.
    /// </summary>
    public sealed partial class StreamTextResponse
    {
        /// <summary>
        /// This field is always set to `text_generation` for this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.StreamTextResponseEventType EventType { get; set; }

        /// <summary>
        /// A fragment of the generated text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTextResponse" /> class.
        /// </summary>
        /// <param name="eventType">
        /// This field is always set to `text_generation` for this event.
        /// </param>
        /// <param name="text">
        /// A fragment of the generated text.
        /// </param>
        public StreamTextResponse(
            global::G.StreamTextResponseEventType eventType,
            string? text)
        {
            this.EventType = eventType;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamTextResponse" /> class.
        /// </summary>
        public StreamTextResponse()
        {
        }
    }
}