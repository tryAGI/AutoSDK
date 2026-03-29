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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookLiveEndSessionPayloadEventJsonConverter))]
        public global::G.WebhookLiveEndSessionPayloadEvent Event { get; set; } = global::G.WebhookLiveEndSessionPayloadEvent.LiveEndSession;

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
        /// Initializes a new instance of the <see cref="WebhookLiveEndSessionPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.end_session<br/>
        /// Example: live.end_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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