//HintName: G.Models.AutomationRuleEvaluatorLlmAsJudge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorLlmAsJudge : global::G.AutomationRuleEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.TraceFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.LlmAsJudgeCode? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudge" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorLlmAsJudge(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceFilter>? filters,
            global::G.LlmAsJudgeCode? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudge" /> class.
        /// </summary>
        public AutomationRuleEvaluatorLlmAsJudge()
        {
        }
    }
}