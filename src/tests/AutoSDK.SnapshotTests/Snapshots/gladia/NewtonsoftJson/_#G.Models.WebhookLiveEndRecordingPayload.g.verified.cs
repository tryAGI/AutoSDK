//HintName: G.Models.WebhookLiveEndRecordingPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLiveEndRecordingPayload
    {
        /// <summary>
        /// Default Value: live.end_recording<br/>
        /// Example: live.end_recording
        /// </summary>
        /// <default>global::G.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording</default>
        /// <example>live.end_recording</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookLiveEndRecordingPayloadEvent Event { get; set; } = global::G.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LiveEventPayload Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveEndRecordingPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.end_recording<br/>
        /// Example: live.end_recording
        /// </param>
        public WebhookLiveEndRecordingPayload(
            global::G.LiveEventPayload payload,
            global::G.WebhookLiveEndRecordingPayloadEvent @event = global::G.WebhookLiveEndRecordingPayloadEvent.LiveEndRecording)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveEndRecordingPayload" /> class.
        /// </summary>
        public WebhookLiveEndRecordingPayload()
        {
        }
    }
}