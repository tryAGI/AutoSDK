//HintName: G.Models.SendChatMessageResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageResponseDataItem
    {
        /// <summary>
        /// The message id for the message that was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// If the message passed all checks and was sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_sent", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsSent { get; set; } = default!;

        /// <summary>
        /// The reason the message was dropped, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("drop_reason")]
        public global::System.Collections.Generic.IList<global::G.SendChatMessageResponseDataItemDropReasonItem>? DropReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItem" /> class.
        /// </summary>
        /// <param name="messageId">
        /// The message id for the message that was sent.
        /// </param>
        /// <param name="isSent">
        /// If the message passed all checks and was sent.
        /// </param>
        /// <param name="dropReason">
        /// The reason the message was dropped, if any.
        /// </param>
        public SendChatMessageResponseDataItem(
            string messageId,
            bool isSent,
            global::System.Collections.Generic.IList<global::G.SendChatMessageResponseDataItemDropReasonItem>? dropReason)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.IsSent = isSent;
            this.DropReason = dropReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItem" /> class.
        /// </summary>
        public SendChatMessageResponseDataItem()
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
        public static global::G.SendChatMessageResponseDataItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SendChatMessageResponseDataItem>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SendChatMessageResponseDataItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SendChatMessageResponseDataItem?>(serializer.Deserialize<global::G.SendChatMessageResponseDataItem>(jsonReader));
        }

    }
}