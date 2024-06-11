//HintName: G.Models.CreateChatCompletionResponseChoicesLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log probability information for the choice.
    /// </summary>
    public sealed partial class CreateChatCompletionResponseChoicesLogprobs
    {
        /// <summary>
        /// A list of message content tokens with log probability information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionTokenLogprob>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}