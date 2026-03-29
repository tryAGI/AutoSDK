//HintName: G.Models.RegenerateParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegenerateParam
    {
        /// <summary>
        /// 对于 openapi 来说，这个字段是必传的。但是这里为了兼容老版本，所以设置为可选
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MessageId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateParam" /> class.
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="chatId">
        /// 对于 openapi 来说，这个字段是必传的。但是这里为了兼容老版本，所以设置为可选
        /// </param>
        public RegenerateParam(
            string messageId,
            string? chatId)
        {
            this.ChatId = chatId;
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateParam" /> class.
        /// </summary>
        public RegenerateParam()
        {
        }
    }
}