//HintName: G.Models.AutomationRuleEvaluatorSpanUserDefinedMetricPython.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanUserDefinedMetricPython : global::G.AutomationRuleEvaluator
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
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorSpanUserDefinedMetricPython(
            string name,
            global::System.Collections.Generic.IList<global::G.SpanFilter>? filters,
            global::G.SpanUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanUserDefinedMetricPython()
        {
        }
    }
}