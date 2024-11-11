//HintName: G.Models.UpdateConduitShardsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseDataItem
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
        public global::G.UpdateConduitShardsResponseDataItemStatus Status { get; set; } = default!;

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateConduitShardsResponseDataItemTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItem" /> class.
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
        public UpdateConduitShardsResponseDataItem(
            string id,
            global::G.UpdateConduitShardsResponseDataItemStatus status,
            global::G.UpdateConduitShardsResponseDataItemTransport transport)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponseDataItem" /> class.
        /// </summary>
        public UpdateConduitShardsResponseDataItem()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UpdateConduitShardsResponseDataItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateConduitShardsResponseDataItem>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.UpdateConduitShardsResponseDataItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.UpdateConduitShardsResponseDataItem?>(serializer.Deserialize<global::G.UpdateConduitShardsResponseDataItem>(jsonReader));
        }

    }
}