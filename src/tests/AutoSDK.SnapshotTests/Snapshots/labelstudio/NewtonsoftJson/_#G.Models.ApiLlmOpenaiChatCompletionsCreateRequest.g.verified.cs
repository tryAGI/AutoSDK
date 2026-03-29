//HintName: G.Models.ApiLlmOpenaiChatCompletionsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiLlmOpenaiChatCompletionsCreateRequest
    {
        /// <summary>
        /// Array of message objects for the chat completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Model identifier. Can be "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name"<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Array of message objects for the chat completion
        /// </param>
        /// <param name="model">
        /// Model identifier. Can be "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name"<br/>
        /// Example: gpt-4
        /// </param>
        public ApiLlmOpenaiChatCompletionsCreateRequest(
            global::System.Collections.Generic.IList<global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessage> messages,
            string model)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLlmOpenaiChatCompletionsCreateRequest" /> class.
        /// </summary>
        public ApiLlmOpenaiChatCompletionsCreateRequest()
        {
        }
    }
}