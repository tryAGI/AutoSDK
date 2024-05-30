//HintName: G.Models.UpdateConduitShardsResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseData
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  
        ///   
        /// * enabled — The shard is enabled.
        /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.
        /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.
        /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.
        /// * websocket\_disconnected — The client closed the connection.
        /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.
        /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).
        /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.
        /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.
        /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required UpdateConduitShardsResponseDataStatus Status { get; set; }

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required UpdateConduitShardsResponseDataTransport Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}