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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StreamTextResponseEventTypeJsonConverter))]
        public global::G.StreamTextResponseEventType EventType { get; set; }

        /// <summary>
        /// A fragment of the generated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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