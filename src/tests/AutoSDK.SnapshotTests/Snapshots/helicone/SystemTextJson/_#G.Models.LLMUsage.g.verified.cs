//HintName: G.Models.LLMUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LLMUsageTotalCost TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsage" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalCount"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="totalCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsage(
            string model,
            string provider,
            double promptTokens,
            double completionTokens,
            double totalCount,
            double amount,
            string description,
            global::G.LLMUsageTotalCost totalCost)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalCount = totalCount;
            this.Amount = amount;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TotalCost = totalCost ?? throw new global::System.ArgumentNullException(nameof(totalCost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsage" /> class.
        /// </summary>
        public LLMUsage()
        {
        }
    }
}