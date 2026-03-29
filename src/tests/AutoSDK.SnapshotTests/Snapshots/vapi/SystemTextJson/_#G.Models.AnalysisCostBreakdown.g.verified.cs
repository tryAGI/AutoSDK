//HintName: G.Models.AnalysisCostBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalysisCostBreakdown
    {
        /// <summary>
        /// This is the cost to summarize the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public double? Summary { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used to summarize the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryPromptTokens")]
        public double? SummaryPromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens used to summarize the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryCompletionTokens")]
        public double? SummaryCompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used to summarize the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryCachedPromptTokens")]
        public double? SummaryCachedPromptTokens { get; set; }

        /// <summary>
        /// This is the cost to extract structured data from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredData")]
        public double? StructuredData { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used to extract structured data from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredDataPromptTokens")]
        public double? StructuredDataPromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens used to extract structured data from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredDataCompletionTokens")]
        public double? StructuredDataCompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used to extract structured data from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredDataCachedPromptTokens")]
        public double? StructuredDataCachedPromptTokens { get; set; }

        /// <summary>
        /// This is the cost to evaluate if the call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successEvaluation")]
        public double? SuccessEvaluation { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used to evaluate if the call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successEvaluationPromptTokens")]
        public double? SuccessEvaluationPromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens used to evaluate if the call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successEvaluationCompletionTokens")]
        public double? SuccessEvaluationCompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used to evaluate if the call was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successEvaluationCachedPromptTokens")]
        public double? SuccessEvaluationCachedPromptTokens { get; set; }

        /// <summary>
        /// This is the cost to evaluate structuredOutputs from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutput")]
        public double? StructuredOutput { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used to evaluate structuredOutputs from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputPromptTokens")]
        public double? StructuredOutputPromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens used to evaluate structuredOutputs from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputCompletionTokens")]
        public double? StructuredOutputCompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used to evaluate structuredOutputs from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputCachedPromptTokens")]
        public double? StructuredOutputCachedPromptTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCostBreakdown" /> class.
        /// </summary>
        /// <param name="summary">
        /// This is the cost to summarize the call.
        /// </param>
        /// <param name="summaryPromptTokens">
        /// This is the number of prompt tokens used to summarize the call.
        /// </param>
        /// <param name="summaryCompletionTokens">
        /// This is the number of completion tokens used to summarize the call.
        /// </param>
        /// <param name="summaryCachedPromptTokens">
        /// This is the number of cached prompt tokens used to summarize the call.
        /// </param>
        /// <param name="structuredData">
        /// This is the cost to extract structured data from the call.
        /// </param>
        /// <param name="structuredDataPromptTokens">
        /// This is the number of prompt tokens used to extract structured data from the call.
        /// </param>
        /// <param name="structuredDataCompletionTokens">
        /// This is the number of completion tokens used to extract structured data from the call.
        /// </param>
        /// <param name="structuredDataCachedPromptTokens">
        /// This is the number of cached prompt tokens used to extract structured data from the call.
        /// </param>
        /// <param name="successEvaluation">
        /// This is the cost to evaluate if the call was successful.
        /// </param>
        /// <param name="successEvaluationPromptTokens">
        /// This is the number of prompt tokens used to evaluate if the call was successful.
        /// </param>
        /// <param name="successEvaluationCompletionTokens">
        /// This is the number of completion tokens used to evaluate if the call was successful.
        /// </param>
        /// <param name="successEvaluationCachedPromptTokens">
        /// This is the number of cached prompt tokens used to evaluate if the call was successful.
        /// </param>
        /// <param name="structuredOutput">
        /// This is the cost to evaluate structuredOutputs from the call.
        /// </param>
        /// <param name="structuredOutputPromptTokens">
        /// This is the number of prompt tokens used to evaluate structuredOutputs from the call.
        /// </param>
        /// <param name="structuredOutputCompletionTokens">
        /// This is the number of completion tokens used to evaluate structuredOutputs from the call.
        /// </param>
        /// <param name="structuredOutputCachedPromptTokens">
        /// This is the number of cached prompt tokens used to evaluate structuredOutputs from the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisCostBreakdown(
            double? summary,
            double? summaryPromptTokens,
            double? summaryCompletionTokens,
            double? summaryCachedPromptTokens,
            double? structuredData,
            double? structuredDataPromptTokens,
            double? structuredDataCompletionTokens,
            double? structuredDataCachedPromptTokens,
            double? successEvaluation,
            double? successEvaluationPromptTokens,
            double? successEvaluationCompletionTokens,
            double? successEvaluationCachedPromptTokens,
            double? structuredOutput,
            double? structuredOutputPromptTokens,
            double? structuredOutputCompletionTokens,
            double? structuredOutputCachedPromptTokens)
        {
            this.Summary = summary;
            this.SummaryPromptTokens = summaryPromptTokens;
            this.SummaryCompletionTokens = summaryCompletionTokens;
            this.SummaryCachedPromptTokens = summaryCachedPromptTokens;
            this.StructuredData = structuredData;
            this.StructuredDataPromptTokens = structuredDataPromptTokens;
            this.StructuredDataCompletionTokens = structuredDataCompletionTokens;
            this.StructuredDataCachedPromptTokens = structuredDataCachedPromptTokens;
            this.SuccessEvaluation = successEvaluation;
            this.SuccessEvaluationPromptTokens = successEvaluationPromptTokens;
            this.SuccessEvaluationCompletionTokens = successEvaluationCompletionTokens;
            this.SuccessEvaluationCachedPromptTokens = successEvaluationCachedPromptTokens;
            this.StructuredOutput = structuredOutput;
            this.StructuredOutputPromptTokens = structuredOutputPromptTokens;
            this.StructuredOutputCompletionTokens = structuredOutputCompletionTokens;
            this.StructuredOutputCachedPromptTokens = structuredOutputCachedPromptTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisCostBreakdown" /> class.
        /// </summary>
        public AnalysisCostBreakdown()
        {
        }
    }
}