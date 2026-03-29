//HintName: G.Models.WebhookLiveEndSessionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLiveEndSessionPayload
    {
        /// <summary>
        /// Default Value: live.end_session<br/>
        /// Example: live.end_session
        /// </summary>
        /// <default>global::G.WebhookLiveEndSessionPayloadEvent.LiveEndSession</default>
        /// <example>live.end_session</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookLiveEndSessionPayloadEvent Event { get; set; } = global::G.WebhookLiveEndSessionPayloadEvent.LiveEndSession;

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
        /// Initializes a new instance of the <see cref="WebhookLiveEndSessionPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.end_session<br/>
        /// Example: live.end_session
        /// </param>
        public WebhookLiveEndSessionPayload(
            global::G.LiveEventPayload payload,
            global::G.WebhookLiveEndSessionPayloadEvent @event = global::G.WebhookLiveEndSessionPayloadEvent.LiveEndSession)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveEndSessionPayload" /> class.
        /// </summary>
        public WebhookLiveEndSessionPayload()
        {
        }
    }
}