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
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ApiLlmOpenaiChatCompletionsCreateRequestMessage> Messages { get; set; }

        /// <summary>
        /// Model identifier. Can be "model_name" (defaults to OpenAI), "provider/model_name", or "provider:model_name"<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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