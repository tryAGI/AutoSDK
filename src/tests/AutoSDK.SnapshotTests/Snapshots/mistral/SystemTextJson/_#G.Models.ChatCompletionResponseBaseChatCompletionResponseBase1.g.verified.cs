//HintName: G.Models.ChatCompletionResponseBaseChatCompletionResponseBase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseBaseChatCompletionResponseBase1
    {
        /// <summary>
        /// Example: 1702256327
        /// </summary>
        /// <example>1702256327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseBaseChatCompletionResponseBase1" /> class.
        /// </summary>
        /// <param name="created">
        /// Example: 1702256327
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseBaseChatCompletionResponseBase1(
            int? created)
        {
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseBaseChatCompletionResponseBase1" /> class.
        /// </summary>
        public ChatCompletionResponseBaseChatCompletionResponseBase1()
        {
        }
    }
}