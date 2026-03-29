//HintName: G.Models.AutomationRuleEvaluatorSpanLlmAsJudgePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanLlmAsJudgePublic : global::G.AutomationRuleEvaluatorPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public global::G.SpanLlmAsJudgeCodePublic? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorSpanLlmAsJudgePublic(
            string name,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? filters,
            global::G.SpanLlmAsJudgeCodePublic? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublic" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanLlmAsJudgePublic()
        {
        }
    }
}