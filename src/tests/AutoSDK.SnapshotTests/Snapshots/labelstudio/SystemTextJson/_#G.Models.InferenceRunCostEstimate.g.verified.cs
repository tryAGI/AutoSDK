//HintName: G.Models.InferenceRunCostEstimate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceRunCostEstimate
    {
        /// <summary>
        /// Cost of the completion (in USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost_usd")]
        public string? CompletionCostUsd { get; set; }

        /// <summary>
        /// Error message details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Type of error (e.g. "Timeout", "Rate Limit", etc)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Whether an error occurred or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Cost of the prompt (in USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost_usd")]
        public string? PromptCostUsd { get; set; }

        /// <summary>
        /// Total cost of the inference (in USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public string? TotalCostUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRunCostEstimate" /> class.
        /// </summary>
        /// <param name="completionCostUsd">
        /// Cost of the completion (in USD)
        /// </param>
        /// <param name="errorMessage">
        /// Error message details
        /// </param>
        /// <param name="errorType">
        /// Type of error (e.g. "Timeout", "Rate Limit", etc)
        /// </param>
        /// <param name="isError">
        /// Whether an error occurred or not
        /// </param>
        /// <param name="promptCostUsd">
        /// Cost of the prompt (in USD)
        /// </param>
        /// <param name="totalCostUsd">
        /// Total cost of the inference (in USD)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRunCostEstimate(
            string? completionCostUsd,
            string? errorMessage,
            string? errorType,
            bool? isError,
            string? promptCostUsd,
            string? totalCostUsd)
        {
            this.CompletionCostUsd = completionCostUsd;
            this.ErrorMessage = errorMessage;
            this.ErrorType = errorType;
            this.IsError = isError;
            this.PromptCostUsd = promptCostUsd;
            this.TotalCostUsd = totalCostUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRunCostEstimate" /> class.
        /// </summary>
        public InferenceRunCostEstimate()
        {
        }
    }
}