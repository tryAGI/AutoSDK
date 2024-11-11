//HintName: G.Models.UpdateConduitShardsResponseDataItemTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details used to send the notifications.
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseDataItemTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateConduitShardsResponseDataItemTransportMethod Method { get; set; } = default!;

        /// <summary>
        /// The callback URL where the notifications are sent. Included only if method is set to webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnected_at")]
        public global::System.DateTime? DisconnectedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItemTransport" /> class.
        /// </summary>
        /// <param name="method">
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket
        /// </param>
        /// <param name="callback">
        /// The callback URL where the notifications are sent. Included only if method is set to webhook.
        /// </param>
        /// <param name="sessionId">
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.
        /// </param>
        /// <param name="connectedAt">
        /// The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.
        /// </param>
        /// <param name="disconnectedAt">
        /// The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.
        /// </param>
        public UpdateConduitShardsResponseDataItemTransport(
            global::G.UpdateConduitShardsResponseDataItemTransportMethod method,
            string? callback,
            string? sessionId,
            global::System.DateTime? connectedAt,
            global::System.DateTime? disconnectedAt)
        {
            this.Method = method;
            this.Callback = callback;
            this.SessionId = sessionId;
            this.ConnectedAt = connectedAt;
            this.DisconnectedAt = disconnectedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItemTransport" /> class.
        /// </summary>
        public UpdateConduitShardsResponseDataItemTransport()
        {
        }
    }
}