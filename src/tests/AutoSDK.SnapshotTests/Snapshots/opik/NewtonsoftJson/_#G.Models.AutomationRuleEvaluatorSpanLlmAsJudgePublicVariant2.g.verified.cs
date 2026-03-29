//HintName: G.Models.AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="code"></param>
        public AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2(
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? filters,
            global::G.SpanLlmAsJudgeCodePublic? code)
        {
            this.Filters = filters;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2" /> class.
        /// </summary>
        public AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2()
        {
        }
    }
}