//HintName: G.Models.WebhookTranscriptionCreatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTranscriptionCreatedPayload
    {
        /// <summary>
        /// Default Value: transcription.created<br/>
        /// Example: transcription.created
        /// </summary>
        /// <default>global::G.WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated</default>
        /// <example>transcription.created</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookTranscriptionCreatedPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated;

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
        /// Initializes a new instance of the <see cref="WebhookTranscriptionCreatedPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.created<br/>
        /// Example: transcription.created
        /// </param>
        public WebhookTranscriptionCreatedPayload(
            global::G.PreRecordedEventPayload payload,
            global::G.WebhookTranscriptionCreatedPayloadEvent @event = global::G.WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTranscriptionCreatedPayload" /> class.
        /// </summary>
        public WebhookTranscriptionCreatedPayload()
        {
        }
    }
}