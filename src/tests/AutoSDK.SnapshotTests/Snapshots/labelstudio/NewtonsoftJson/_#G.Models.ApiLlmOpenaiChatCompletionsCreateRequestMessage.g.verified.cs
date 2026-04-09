//HintName: G.Models.ApiLlmOpenaiChatCompletionsCreateRequestMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateRequestMessage
    {
        /// <summary>
        /// The content of the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The role of the message author
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter))]
        public global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequestMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message
        /// </param>
        /// <param name="role">
        /// The role of the message author
        /// </param>
        public ApiLlmOpenaiChatCompletionsCreateRequestMessage(
            string content,
            global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessageRole role)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequestMessage" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateRequestMessage()
        {
        }
    }
}