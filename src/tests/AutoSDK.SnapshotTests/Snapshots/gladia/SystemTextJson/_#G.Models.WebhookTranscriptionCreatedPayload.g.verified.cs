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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookTranscriptionCreatedPayloadEventJsonConverter))]
        public global::G.WebhookTranscriptionCreatedPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated;

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
        /// Initializes a new instance of the <see cref="WebhookTranscriptionCreatedPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.created<br/>
        /// Example: transcription.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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