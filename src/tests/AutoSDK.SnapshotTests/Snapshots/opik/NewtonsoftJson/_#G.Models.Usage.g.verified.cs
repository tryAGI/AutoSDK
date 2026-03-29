//HintName: G.Models.Usage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_details")]
        public global::G.PromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_details")]
        public global::G.CompletionTokensDetails? CompletionTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="promptTokensDetails"></param>
        /// <param name="completionTokens"></param>
        /// <param name="completionTokensDetails"></param>
        public Usage(
            int? totalTokens,
            int? promptTokens,
            global::G.PromptTokensDetails? promptTokensDetails,
            int? completionTokens,
            global::G.CompletionTokensDetails? completionTokensDetails)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.PromptTokensDetails = promptTokensDetails;
            this.CompletionTokens = completionTokens;
            this.CompletionTokensDetails = completionTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}