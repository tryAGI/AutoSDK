//HintName: G.Models.AutomationRuleEvaluatorLlmAsJudgeWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorLlmAsJudgeWrite : global::G.AutomationRuleEvaluatorWrite
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
        public global::G.LlmAsJudgeCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorLlmAsJudgeWrite(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceFilterWrite>? filters,
            global::G.LlmAsJudgeCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorLlmAsJudgeWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorLlmAsJudgeWrite()
        {
        }
    }
}