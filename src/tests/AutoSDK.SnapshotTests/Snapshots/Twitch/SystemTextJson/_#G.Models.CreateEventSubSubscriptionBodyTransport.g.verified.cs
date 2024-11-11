//HintName: G.Models.CreateEventSubSubscriptionBodyTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details that you want Twitch to use when sending you notifications.
    /// </summary>
    public sealed partial class CreateEventSubSubscriptionBodyTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket<br/>
        /// * conduit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateEventSubSubscriptionBodyTransportMethod Method { get; set; }

        /// <summary>
        /// The callback URL where the notifications are sent. The URL must use the HTTPS protocol and port 443\. See [Processing an event](https://dev.twitch.tv/docs/eventsub/handling-webhook-events#processing-an-event). Specify this field only if `method` is set to **webhook**.<br/>
        /// **NOTE**: Redirects are not followed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// The secret used to verify the signature. The secret must be an ASCII string that’s a minimum of 10 characters long and a maximum of 100 characters long. For information about how the secret is used, see [Verifying the event message](https://dev.twitch.tv/docs/eventsub/handling-webhook-events#verifying-the-event-message). Specify this field only if `method` is set to **webhook**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket to send notifications to. When you connect to EventSub using WebSockets, the server returns the ID in the Welcome message. Specify this field only if `method` is set to **websocket**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// An ID that identifies the conduit to send notifications to. When you create a conduit, the server returns the conduit ID. Specify this field only if `method` is set to **conduit**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conduit_id")]
        public string? ConduitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionBodyTransport" /> class.
        /// </summary>
        /// <param name="method">
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket<br/>
        /// * conduit
        /// </param>
        /// <param name="callback">
        /// The callback URL where the notifications are sent. The URL must use the HTTPS protocol and port 443\. See [Processing an event](https://dev.twitch.tv/docs/eventsub/handling-webhook-events#processing-an-event). Specify this field only if `method` is set to **webhook**.<br/>
        /// **NOTE**: Redirects are not followed.
        /// </param>
        /// <param name="secret">
        /// The secret used to verify the signature. The secret must be an ASCII string that’s a minimum of 10 characters long and a maximum of 100 characters long. For information about how the secret is used, see [Verifying the event message](https://dev.twitch.tv/docs/eventsub/handling-webhook-events#verifying-the-event-message). Specify this field only if `method` is set to **webhook**.
        /// </param>
        /// <param name="sessionId">
        /// An ID that identifies the WebSocket to send notifications to. When you connect to EventSub using WebSockets, the server returns the ID in the Welcome message. Specify this field only if `method` is set to **websocket**.
        /// </param>
        /// <param name="conduitId">
        /// An ID that identifies the conduit to send notifications to. When you create a conduit, the server returns the conduit ID. Specify this field only if `method` is set to **conduit**.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateEventSubSubscriptionBodyTransport(
            global::G.CreateEventSubSubscriptionBodyTransportMethod method,
            string? callback,
            string? secret,
            string? sessionId,
            string? conduitId)
        {
            this.Method = method;
            this.Callback = callback;
            this.Secret = secret;
            this.SessionId = sessionId;
            this.ConduitId = conduitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionBodyTransport" /> class.
        /// </summary>
        public CreateEventSubSubscriptionBodyTransport()
        {
        }
    }
}