//HintName: G.Models.AutomationRuleEvaluatorTraceThreadLlmAsJudge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadLlmAsJudge : global::G.AutomationRuleEvaluator
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
        public global::G.TraceThreadLlmAsJudgeCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudge" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorTraceThreadLlmAsJudge(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? filters,
            global::G.TraceThreadLlmAsJudgeCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudge" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadLlmAsJudge()
        {
        }
    }
}