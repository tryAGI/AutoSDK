//HintName: G.Models.WebhookLiveStartRecordingPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLiveStartRecordingPayload
    {
        /// <summary>
        /// Default Value: live.start_recording<br/>
        /// Example: live.start_recording
        /// </summary>
        /// <default>global::G.WebhookLiveStartRecordingPayloadEvent.LiveStartRecording</default>
        /// <example>live.start_recording</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookLiveStartRecordingPayloadEventJsonConverter))]
        public global::G.WebhookLiveStartRecordingPayloadEvent Event { get; set; } = global::G.WebhookLiveStartRecordingPayloadEvent.LiveStartRecording;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LiveEventPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveStartRecordingPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.start_recording<br/>
        /// Example: live.start_recording
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveStartRecordingPayload(
            global::G.LiveEventPayload payload,
            global::G.WebhookLiveStartRecordingPayloadEvent @event = global::G.WebhookLiveStartRecordingPayloadEvent.LiveStartRecording)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveStartRecordingPayload" /> class.
        /// </summary>
        public WebhookLiveStartRecordingPayload()
        {
        }
    }
}