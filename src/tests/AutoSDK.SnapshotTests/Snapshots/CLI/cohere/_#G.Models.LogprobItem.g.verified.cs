//HintName: G.Models.LogprobItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogprobItem
    {
        /// <summary>
        /// The text chunk for which the log probabilities was calculated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The token ids of each token used to construct the text chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> TokenIds { get; set; }

        /// <summary>
        /// The log probability of each token used to construct the text chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<float>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobItem" /> class.
        /// </summary>
        /// <param name="text">
        /// The text chunk for which the log probabilities was calculated.
        /// </param>
        /// <param name="tokenIds">
        /// The token ids of each token used to construct the text chunk.
        /// </param>
        /// <param name="logprobs">
        /// The log probability of each token used to construct the text chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogprobItem(
            global::System.Collections.Generic.IList<int> tokenIds,
            string? text,
            global::System.Collections.Generic.IList<float>? logprobs)
        {
            this.TokenIds = tokenIds ?? throw new global::System.ArgumentNullException(nameof(tokenIds));
            this.Text = text;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobItem" /> class.
        /// </summary>
        public LogprobItem()
        {
        }
    }
}