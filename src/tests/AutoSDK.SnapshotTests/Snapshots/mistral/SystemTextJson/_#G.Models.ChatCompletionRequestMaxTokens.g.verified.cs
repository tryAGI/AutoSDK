//HintName: G.Models.ChatCompletionRequestMaxTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
    /// </summary>
    public sealed partial class ChatCompletionRequestMaxTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}