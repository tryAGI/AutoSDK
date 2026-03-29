//HintName: G.Models.TokensPerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokensPerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_prompt_tokens_per_response", Required = global::Newtonsoft.Json.Required.Always)]
        public double AveragePromptTokensPerResponse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_completion_tokens_per_response", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageCompletionTokensPerResponse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average_total_tokens_per_response", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageTotalTokensPerResponse { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensPerRequest" /> class.
        /// </summary>
        /// <param name="averagePromptTokensPerResponse"></param>
        /// <param name="averageCompletionTokensPerResponse"></param>
        /// <param name="averageTotalTokensPerResponse"></param>
        public TokensPerRequest(
            double averagePromptTokensPerResponse,
            double averageCompletionTokensPerResponse,
            double averageTotalTokensPerResponse)
        {
            this.AveragePromptTokensPerResponse = averagePromptTokensPerResponse;
            this.AverageCompletionTokensPerResponse = averageCompletionTokensPerResponse;
            this.AverageTotalTokensPerResponse = averageTotalTokensPerResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensPerRequest" /> class.
        /// </summary>
        public TokensPerRequest()
        {
        }
    }
}