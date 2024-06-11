//HintName: G.Models.EventSubSubscriptionTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details used to send the notifications.
    /// </summary>
    public sealed partial class EventSubSubscriptionTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  
        ///   
        /// * webhook
        /// * websocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventSubSubscriptionTransportMethod Method { get; set; } = default!;

        /// <summary>
        /// The callback URL where the notifications are sent. Included only if `method` is set to **webhook**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if `method` is set to **websocket**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was established. Included only if `method` is set to **websocket**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_at")]
        public global::System.DateTime ConnectedAt { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was lost. Included only if `method` is set to **websocket**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnected_at")]
        public global::System.DateTime DisconnectedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}