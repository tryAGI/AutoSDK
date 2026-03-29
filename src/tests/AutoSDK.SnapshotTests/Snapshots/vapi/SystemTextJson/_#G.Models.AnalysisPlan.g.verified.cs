//HintName: G.Models.AnalysisPlan.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalysisPlan
    {
        /// <summary>
        /// The minimum number of messages required to run the analysis plan.<br/>
        /// If the number of messages is less than this, analysis will be skipped.<br/>
        /// @default 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minMessagesThreshold")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? MinMessagesThreshold { get; set; }

        /// <summary>
        /// This is the plan for generating the summary of the call. This outputs to `call.analysis.summary`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaryPlan")]
        public global::G.SummaryPlan? SummaryPlan { get; set; }

        /// <summary>
        /// This is the plan for generating the structured data from the call. This outputs to `call.analysis.structuredData`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredDataPlan")]
        public global::G.StructuredDataPlan? StructuredDataPlan { get; set; }

        /// <summary>
        /// This is an array of structured data plan catalogs. Each entry includes a `key` and a `plan` for generating the structured data from the call. This outputs to `call.analysis.structuredDataMulti`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredDataMultiPlan")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.StructuredDataMultiPlan>? StructuredDataMultiPlan { get; set; }

        /// <summary>
        /// This is the plan for generating the success evaluation of the call. This outputs to `call.analysis.successEvaluation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successEvaluationPlan")]
        public global::G.SuccessEvaluationPlan? SuccessEvaluationPlan { get; set; }

        /// <summary>
        /// This is an array of outcome UUIDs to be calculated during analysis.<br/>
        /// The outcomes will be calculated and stored in `call.analysis.outcomes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcomeIds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? OutcomeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}