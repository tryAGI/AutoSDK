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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookLiveStartSessionPayloadEventJsonConverter))]
        public global::G.WebhookLiveStartSessionPayloadEvent Event { get; set; } = global::G.WebhookLiveStartSessionPayloadEvent.LiveStartSession;

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
        /// Initializes a new instance of the <see cref="WebhookLiveStartSessionPayload" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="event">
        /// Default Value: live.start_session<br/>
        /// Example: live.start_session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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