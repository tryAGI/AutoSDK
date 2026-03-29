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
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookTranscriptionErrorPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionErrorPayloadEvent.TranscriptionError;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PreRecordedEventPayload Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionErrorPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </param>
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