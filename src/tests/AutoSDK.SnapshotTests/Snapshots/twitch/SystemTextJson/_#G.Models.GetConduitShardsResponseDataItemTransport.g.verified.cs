//HintName: G.Models.GetConduitShardsResponseDataItemTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport details used to send the notifications.
    /// </summary>
    public sealed partial class GetConduitShardsResponseDataItemTransport
    {
        /// <summary>
        /// The transport method. Possible values are:  <br/>
        ///   <br/>
        /// * webhook<br/>
        /// * websocket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConduitShardsResponseDataItemTransportMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConduitShardsResponseDataItemTransportMethod Method { get; set; }

        /// <summary>
        /// The callback URL where the notifications are sent. Included only if method is set to webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? Callback { get; set; }

        /// <summary>
        /// An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnected_at")]
        public global::System.DateTime? DisconnectedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitShardsResponseDataItemTransport" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConduitShardsResponseDataItemTransport(
            global::G.GetConduitShardsResponseDataItemTransportMethod method,
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
        /// Initializes a new instance of the <see cref="GetConduitShardsResponseDataItemTransport" /> class.
        /// </summary>
        public GetConduitShardsResponseDataItemTransport()
        {
        }
    }
}