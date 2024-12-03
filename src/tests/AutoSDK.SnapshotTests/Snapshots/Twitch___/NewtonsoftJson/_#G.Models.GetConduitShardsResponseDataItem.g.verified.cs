//HintName: G.Models.GetConduitShardsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConduitShardsResponseDataItem
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  <br/>
        ///   <br/>
        /// * enabled — The shard is enabled.<br/>
        /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.<br/>
        /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.<br/>
        /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.<br/>
        /// * websocket\_disconnected — The client closed the connection.<br/>
        /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.<br/>
        /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).<br/>
        /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.<br/>
        /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.<br/>
        /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetConduitShardsResponseDataItemStatus Status { get; set; } = default!;

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetConduitShardsResponseDataItemTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitShardsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Shard ID.
        /// </param>
        /// <param name="status">
        /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  <br/>
        ///   <br/>
        /// * enabled — The shard is enabled.<br/>
        /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.<br/>
        /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.<br/>
        /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.<br/>
        /// * websocket\_disconnected — The client closed the connection.<br/>
        /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.<br/>
        /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).<br/>
        /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.<br/>
        /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.<br/>
        /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
        /// </param>
        /// <param name="transport">
        /// The transport details used to send the notifications.
        /// </param>
        public GetConduitShardsResponseDataItem(
            string id,
            global::G.GetConduitShardsResponseDataItemStatus status,
            global::G.GetConduitShardsResponseDataItemTransport transport)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitShardsResponseDataItem" /> class.
        /// </summary>
        public GetConduitShardsResponseDataItem()
        {
        }
    }
}