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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookTranscriptionSuccessPayloadEventJsonConverter))]
        public global::G.WebhookTranscriptionSuccessPayloadEvent Event { get; set; } = global::G.WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess;

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
        /// Initializes a new instance of the <see cref="WebhookTranscriptionSuccessPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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