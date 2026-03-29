//HintName: G.Models.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython : global::G.AutomationRuleEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::G.TraceThreadUserDefinedMetricPythonCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? filters,
            global::G.TraceThreadUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython()
        {
        }
    }
}