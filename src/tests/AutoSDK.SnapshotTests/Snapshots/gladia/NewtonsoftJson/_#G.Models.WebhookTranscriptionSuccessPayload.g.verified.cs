//HintName: G.Models.WebhookTranscriptionSuccessPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTranscriptionSuccessPayload
    {
        /// <summary>
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </summary>
        /// <default>global::G.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess</default>
        /// <example>transcription.success</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookTranscriptionSuccessPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess;

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
        /// Initializes a new instance of the <see cref="WebhookTranscriptionSuccessPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </param>
        public WebhookTranscriptionSuccessPayload(
            global::G.PreRecordedEventPayload payload,
            global::G.WebhookTranscriptionSuccessPayloadEvent @event = global::G.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionSuccessPayload" /> class.
        /// </summary>
        public WebhookTranscriptionSuccessPayload()
        {
        }
    }
}