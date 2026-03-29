//HintName: G.Models.WebhookTranscriptionErrorPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTranscriptionErrorPayload
    {
        /// <summary>
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </summary>
        /// <default>global::G.WebhookTranscriptionErrorPayloadEvent.TranscriptionError</default>
        /// <example>transcription.error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookTranscriptionErrorPayloadEventJsonConverter))]
        public global::G.WebhookTranscriptionErrorPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionErrorPayloadEvent.TranscriptionError;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PreRecordedEventPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionErrorPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTranscriptionErrorPayload(
            global::G.PreRecordedEventPayload payload,
            global::G.WebhookTranscriptionErrorPayloadEvent @event = global::G.WebhookTranscriptionErrorPayloadEvent.TranscriptionError)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionErrorPayload" /> class.
        /// </summary>
        public WebhookTranscriptionErrorPayload()
        {
        }
    }
}