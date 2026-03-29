//HintName: G.Models.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic : global::G.AutomationRuleEvaluatorPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.TraceThreadLlmAsJudgeCodePublic? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? filters,
            global::G.TraceThreadLlmAsJudgeCodePublic? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic()
        {
        }
    }
}