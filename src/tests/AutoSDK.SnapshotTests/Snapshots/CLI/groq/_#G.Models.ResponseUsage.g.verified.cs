//HintName: G.Models.ResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for the response request.
    /// </summary>
    public sealed partial class ResponseUsage
    {
        /// <summary>
        /// Number of tokens in the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Breakdown of input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseUsageInputTokensDetails InputTokensDetails { get; set; }

        /// <summary>
        /// Number of tokens in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Breakdown of output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseUsageOutputTokensDetails OutputTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens used in the request (input + output).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Number of tokens in the input.
        /// </param>
        /// <param name="inputTokensDetails">
        /// Breakdown of input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// Number of tokens in the generated output.
        /// </param>
        /// <param name="outputTokensDetails">
        /// Breakdown of output tokens.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used in the request (input + output).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsage(
            int inputTokens,
            global::G.ResponseUsageInputTokensDetails inputTokensDetails,
            int outputTokens,
            global::G.ResponseUsageOutputTokensDetails outputTokensDetails,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage" /> class.
        /// </summary>
        public ResponseUsage()
        {
        }
    }
}