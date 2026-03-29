//HintName: G.Models.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.SpanFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::G.SpanUserDefinedMetricPythonCode? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2(
            global::System.Collections.Generic.IList<global::G.SpanFilter>? filters,
            global::G.SpanUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2()
        {
        }
    }
}