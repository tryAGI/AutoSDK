//HintName: G.Models.CreateChatCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// Unique id of the chat to create completion.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("chat_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChatId { get; set; } = default!;

        /// <summary>
        /// user message to generate agent chat completion.<br/>
        /// Example: hi how are you doing?
        /// </summary>
        /// <example>hi how are you doing?</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="chatId">
        /// Unique id of the chat to create completion.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="content">
        /// user message to generate agent chat completion.<br/>
        /// Example: hi how are you doing?
        /// </param>
        public CreateChatCompletionRequest(
            string chatId,
            string content)
        {
            this.ChatId = chatId ?? throw new global::System.ArgumentNullException(nameof(chatId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}