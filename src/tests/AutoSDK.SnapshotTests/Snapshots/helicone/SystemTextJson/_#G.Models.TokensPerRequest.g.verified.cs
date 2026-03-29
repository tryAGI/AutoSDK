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
        [global::System.Text.Json.Serialization.JsonPropertyName("average_prompt_tokens_per_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AveragePromptTokensPerResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_completion_tokens_per_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageCompletionTokensPerResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_total_tokens_per_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageTotalTokensPerResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensPerRequest" /> class.
        /// </summary>
        /// <param name="averagePromptTokensPerResponse"></param>
        /// <param name="averageCompletionTokensPerResponse"></param>
        /// <param name="averageTotalTokensPerResponse"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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