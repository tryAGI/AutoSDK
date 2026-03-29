//HintName: G.Models.WebhookLiveStartSessionPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookLiveStartSessionPayload
    {
        /// <summary>
        /// Default Value: live.start_session<br/>
        /// Example: live.start_session
        /// </summary>
        /// <default>global::G.WebhookLiveStartSessionPayloadEvent.LiveStartSession</default>
        /// <example>live.start_session</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.WebhookLiveStartSessionPayloadEvent Event { get; set; } = global::G.WebhookLiveStartSessionPayloadEvent.LiveStartSession;

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
        /// Initializes a new instance of the <see cref="WebhookLiveStartSessionPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.start_session<br/>
        /// Example: live.start_session
        /// </param>
        public WebhookLiveStartSessionPayload(
            global::G.LiveEventPayload payload,
            global::G.WebhookLiveStartSessionPayloadEvent @event = global::G.WebhookLiveStartSessionPayloadEvent.LiveStartSession)
        {
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveStartSessionPayload" /> class.
        /// </summary>
        public WebhookLiveStartSessionPayload()
        {
        }
    }
}