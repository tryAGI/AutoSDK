//HintName: G.Models.ManageHeldAutoModMessagesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageHeldAutoModMessagesBody
    {
        /// <summary>
        /// The moderator who is approving or denying the held message. This ID must match the user ID in the access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The ID of the message to allow or deny.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MsgId { get; set; } = default!;

        /// <summary>
        /// The action to take for the message. Possible values are:  <br/>
        ///   <br/>
        /// * ALLOW<br/>
        /// * DENY
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ManageHeldAutoModMessagesBodyAction Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageHeldAutoModMessagesBody" /> class.
        /// </summary>
        /// <param name="userId">
        /// The moderator who is approving or denying the held message. This ID must match the user ID in the access token.
        /// </param>
        /// <param name="msgId">
        /// The ID of the message to allow or deny.
        /// </param>
        /// <param name="action">
        /// The action to take for the message. Possible values are:  <br/>
        ///   <br/>
        /// * ALLOW<br/>
        /// * DENY
        /// </param>
        public ManageHeldAutoModMessagesBody(
            string userId,
            string msgId,
            global::G.ManageHeldAutoModMessagesBodyAction action)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.MsgId = msgId ?? throw new global::System.ArgumentNullException(nameof(msgId));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageHeldAutoModMessagesBody" /> class.
        /// </summary>
        public ManageHeldAutoModMessagesBody()
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
        public static global::G.ManageHeldAutoModMessagesBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ManageHeldAutoModMessagesBody>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ManageHeldAutoModMessagesBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ManageHeldAutoModMessagesBody?>(serializer.Deserialize<global::G.ManageHeldAutoModMessagesBody>(jsonReader));
        }

    }
}