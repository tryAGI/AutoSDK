//HintName: G.Models.AutomationRuleEvaluatorSpanLlmAsJudge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanLlmAsJudge : global::G.AutomationRuleEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.SpanFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.SpanLlmAsJudgeCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudge" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorSpanLlmAsJudge(
            string name,
            global::System.Collections.Generic.IList<global::G.SpanFilter>? filters,
            global::G.SpanLlmAsJudgeCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudge" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanLlmAsJudge()
        {
        }
    }
}