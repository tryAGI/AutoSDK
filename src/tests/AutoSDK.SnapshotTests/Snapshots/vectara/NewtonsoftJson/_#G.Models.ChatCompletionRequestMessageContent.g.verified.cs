//HintName: G.Models.ChatCompletionRequestMessageContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The contents of the message. Follows the exact format of the content field in the OpenAI Chat Completions API (https://platform.openai.com/docs/api-reference/chat/create). Can be a string for text-only messages, or an array of content parts for multimodal messages with text and images.
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}