//HintName: G.Models.Analysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Analysis
    {
        /// <summary>
        /// This is the summary of the call. Customize by setting `assistant.analysisPlan.summaryPrompt`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// This is the structured data extracted from the call. Customize by setting `assistant.analysisPlan.structuredDataPrompt` and/or `assistant.analysisPlan.structuredDataSchema`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structuredData")]
        public object? StructuredData { get; set; }

        /// <summary>
        /// This is the structured data catalog of the call. Customize by setting `assistant.analysisPlan.structuredDataMultiPlan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("structuredDataMulti")]
        public global::System.Collections.Generic.IList<object>? StructuredDataMulti { get; set; }

        /// <summary>
        /// This is the evaluation of the call. Customize by setting `assistant.analysisPlan.successEvaluationPrompt` and/or `assistant.analysisPlan.successEvaluationRubric`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successEvaluation")]
        public string? SuccessEvaluation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Analysis" /> class.
        /// </summary>
        /// <param name="summary">
        /// This is the summary of the call. Customize by setting `assistant.analysisPlan.summaryPrompt`.
        /// </param>
        /// <param name="structuredData">
        /// This is the structured data extracted from the call. Customize by setting `assistant.analysisPlan.structuredDataPrompt` and/or `assistant.analysisPlan.structuredDataSchema`.
        /// </param>
        /// <param name="structuredDataMulti">
        /// This is the structured data catalog of the call. Customize by setting `assistant.analysisPlan.structuredDataMultiPlan`.
        /// </param>
        /// <param name="successEvaluation">
        /// This is the evaluation of the call. Customize by setting `assistant.analysisPlan.successEvaluationPrompt` and/or `assistant.analysisPlan.successEvaluationRubric`.
        /// </param>
        public Analysis(
            string? summary,
            object? structuredData,
            global::System.Collections.Generic.IList<object>? structuredDataMulti,
            string? successEvaluation)
        {
            this.Summary = summary;
            this.StructuredData = structuredData;
            this.StructuredDataMulti = structuredDataMulti;
            this.SuccessEvaluation = successEvaluation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Analysis" /> class.
        /// </summary>
        public Analysis()
        {
        }
    }
}