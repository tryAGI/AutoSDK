//HintName: G.Models.SendExtensionPubSubMessageBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendExtensionPubSubMessageBody
    {
        /// <summary>
        /// The target of the message. Possible values are:  <br/>
        ///   <br/>
        /// * broadcast<br/>
        /// * global<br/>
        /// * whisper-&lt;user-id&gt;<br/>
        ///   <br/>
        /// If `is_global_broadcast` is **true**, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTargetItem> Target { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster to send the message to. Don’t include this field if `is_global_broadcast` is set to **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to **true** if the message should be sent to all channels. The default is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_global_broadcast")]
        public bool? IsGlobalBroadcast { get; set; }

        /// <summary>
        /// The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendExtensionPubSubMessageBody" /> class.
        /// </summary>
        /// <param name="target">
        /// The target of the message. Possible values are:  <br/>
        ///   <br/>
        /// * broadcast<br/>
        /// * global<br/>
        /// * whisper-&lt;user-id&gt;<br/>
        ///   <br/>
        /// If `is_global_broadcast` is **true**, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster to send the message to. Don’t include this field if `is_global_broadcast` is set to **true**.
        /// </param>
        /// <param name="isGlobalBroadcast">
        /// A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to **true** if the message should be sent to all channels. The default is **false**.
        /// </param>
        /// <param name="message">
        /// The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.
        /// </param>
        public SendExtensionPubSubMessageBody(
            global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTargetItem> target,
            string broadcasterId,
            string message,
            bool? isGlobalBroadcast)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.IsGlobalBroadcast = isGlobalBroadcast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendExtensionPubSubMessageBody" /> class.
        /// </summary>
        public SendExtensionPubSubMessageBody()
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
        public static global::G.SendExtensionPubSubMessageBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SendExtensionPubSubMessageBody>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SendExtensionPubSubMessageBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SendExtensionPubSubMessageBody?>(serializer.Deserialize<global::G.SendExtensionPubSubMessageBody>(jsonReader));
        }

    }
}