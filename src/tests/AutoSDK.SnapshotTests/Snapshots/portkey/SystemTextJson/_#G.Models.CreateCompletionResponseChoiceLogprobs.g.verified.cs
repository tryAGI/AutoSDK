//HintName: G.Models.CreateCompletionResponseChoiceLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCompletionResponseChoiceLogprobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_offset")]
        public global::System.Collections.Generic.IList<int>? TextOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_logprobs")]
        public global::System.Collections.Generic.IList<double>? TokenLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="textOffset"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="tokens"></param>
        /// <param name="topLogprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCompletionResponseChoiceLogprobs(
            global::System.Collections.Generic.IList<int>? textOffset,
            global::System.Collections.Generic.IList<double>? tokenLogprobs,
            global::System.Collections.Generic.IList<string>? tokens,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>? topLogprobs)
        {
            this.TextOffset = textOffset;
            this.TokenLogprobs = tokenLogprobs;
            this.Tokens = tokens;
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionResponseChoiceLogprobs" /> class.
        /// </summary>
        public CreateCompletionResponseChoiceLogprobs()
        {
        }
    }
}