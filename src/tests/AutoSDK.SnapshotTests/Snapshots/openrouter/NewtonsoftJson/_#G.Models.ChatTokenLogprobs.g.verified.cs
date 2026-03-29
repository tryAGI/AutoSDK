//HintName: G.Models.ChatTokenLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log probabilities for the completion
    /// </summary>
    public sealed partial class ChatTokenLogprobs
    {
        /// <summary>
        /// Log probabilities for content tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.ChatTokenLogprob>? Content { get; set; }

        /// <summary>
        /// Log probabilities for refusal tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public global::System.Collections.Generic.IList<global::G.ChatTokenLogprob>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprobs" /> class.
        /// </summary>
        /// <param name="content">
        /// Log probabilities for content tokens
        /// </param>
        /// <param name="refusal">
        /// Log probabilities for refusal tokens
        /// </param>
        public ChatTokenLogprobs(
            global::System.Collections.Generic.IList<global::G.ChatTokenLogprob>? content,
            global::System.Collections.Generic.IList<global::G.ChatTokenLogprob>? refusal)
        {
            this.Content = content;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTokenLogprobs" /> class.
        /// </summary>
        public ChatTokenLogprobs()
        {
        }
    }
}