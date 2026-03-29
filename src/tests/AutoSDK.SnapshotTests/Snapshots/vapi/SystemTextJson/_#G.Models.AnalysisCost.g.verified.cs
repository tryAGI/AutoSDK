//HintName: G.Models.AnalysisCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalysisCost
    {
        /// <summary>
        /// This is the type of cost, always 'analysis' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalysisCostTypeJsonConverter))]
        public global::G.AnalysisCostType Type { get; set; }

        /// <summary>
        /// This is the type of analysis performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalysisCostAnalysisTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnalysisCostAnalysisType AnalysisType { get; set; }

        /// <summary>
        /// This is the model that was used to perform the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used in the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens generated in the analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used in the analysis. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedPromptTokens")]
        public double? CachedPromptTokens { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCost" /> class.
        /// </summary>
        /// <param name="analysisType">
        /// This is the type of analysis performed.
        /// </param>
        /// <param name="model">
        /// This is the model that was used to perform the analysis.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used in the analysis.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated in the analysis.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'analysis' for this class.
        /// </param>
        /// <param name="cachedPromptTokens">
        /// This is the number of cached prompt tokens used in the analysis. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisCost(
            global::G.AnalysisCostAnalysisType analysisType,
            object model,
            double promptTokens,
            double completionTokens,
            double cost,
            global::G.AnalysisCostType type,
            double? cachedPromptTokens)
        {
            this.Type = type;
            this.AnalysisType = analysisType;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedPromptTokens = cachedPromptTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCost" /> class.
        /// </summary>
        public AnalysisCost()
        {
        }
    }
}