//HintName: G.Models.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython : global::G.AutomationRuleEvaluatorUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.TraceThreadUserDefinedMetricPythonCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? filters,
            global::G.TraceThreadUserDefinedMetricPythonCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython()
        {
        }
    }
}