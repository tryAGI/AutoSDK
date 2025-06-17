﻿//HintName: G.Models.LogprobItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogprobItem
    {
        /// <summary>
        /// The log probability of each token used to construct the text chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<float>? Logprobs { get; set; }

        /// <summary>
        /// The text chunk for which the log probabilities was calculated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The token ids of each token used to construct the text chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> TokenIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobItem" /> class.
        /// </summary>
        /// <param name="logprobs">
        /// The log probability of each token used to construct the text chunk.
        /// </param>
        /// <param name="text">
        /// The text chunk for which the log probabilities was calculated.
        /// </param>
        /// <param name="tokenIds">
        /// The token ids of each token used to construct the text chunk.
        /// </param>
        public LogprobItem(
            global::System.Collections.Generic.IList<int> tokenIds,
            global::System.Collections.Generic.IList<float>? logprobs,
            string? text)
        {
            this.TokenIds = tokenIds ?? throw new global::System.ArgumentNullException(nameof(tokenIds));
            this.Logprobs = logprobs;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobItem" /> class.
        /// </summary>
        public LogprobItem()
        {
        }
    }
}