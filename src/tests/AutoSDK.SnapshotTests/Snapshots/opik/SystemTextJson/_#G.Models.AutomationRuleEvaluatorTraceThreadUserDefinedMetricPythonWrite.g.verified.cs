//HintName: G.Models.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite : global::G.AutomationRuleEvaluatorWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceThreadFilterWrite>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public global::G.TraceThreadUserDefinedMetricPythonCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterWrite>? filters,
            global::G.TraceThreadUserDefinedMetricPythonCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite()
        {
        }
    }
}