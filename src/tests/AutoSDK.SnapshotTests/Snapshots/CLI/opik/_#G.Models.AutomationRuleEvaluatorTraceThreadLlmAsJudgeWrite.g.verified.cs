//HintName: G.Models.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite : global::G.AutomationRuleEvaluatorWrite
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
        public global::G.TraceThreadLlmAsJudgeCodeWrite? Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite(
            string name,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterWrite>? filters,
            global::G.TraceThreadLlmAsJudgeCodeWrite? code)
        {
            this.Filters = filters;
            this.Code = code;
            base.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite" /> class.
        /// </summary>
        public AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite()
        {
        }
    }
}