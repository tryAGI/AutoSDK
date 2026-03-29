//HintName: G.Models.AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceFilterWrite>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.UserDefinedMetricPythonCodeWrite? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2(
            global::System.Collections.Generic.IList<global::G.TraceFilterWrite>? filters,
            global::G.UserDefinedMetricPythonCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2" /> class.
        /// </summary>
        public AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2()
        {
        }
    }
}