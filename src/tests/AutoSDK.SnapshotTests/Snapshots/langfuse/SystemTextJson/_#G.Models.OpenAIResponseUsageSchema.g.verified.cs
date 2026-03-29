//HintName: G.Models.OpenAIResponseUsageSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI Usage schema from Response API
    /// </summary>
    public sealed partial class OpenAIResponseUsageSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? InputTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? OutputTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseUsageSchema" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponseUsageSchema(
            int inputTokens,
            int outputTokens,
            int totalTokens,
            global::System.Collections.Generic.Dictionary<string, int?>? inputTokensDetails,
            global::System.Collections.Generic.Dictionary<string, int?>? outputTokensDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.InputTokensDetails = inputTokensDetails;
            this.OutputTokensDetails = outputTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseUsageSchema" /> class.
        /// </summary>
        public OpenAIResponseUsageSchema()
        {
        }
    }
}