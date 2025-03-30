//HintName: G.Models.ConversationHistoryEvaluationCriteriaResultCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryEvaluationCriteriaResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("criteria_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CriteriaId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluationSuccessResult Result { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rationale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Rationale { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryEvaluationCriteriaResultCommonModel" /> class.
        /// </summary>
        /// <param name="criteriaId"></param>
        /// <param name="result"></param>
        /// <param name="rationale"></param>
        public ConversationHistoryEvaluationCriteriaResultCommonModel(
            string criteriaId,
            global::G.EvaluationSuccessResult result,
            string rationale)
        {
            this.CriteriaId = criteriaId ?? throw new global::System.ArgumentNullException(nameof(criteriaId));
            this.Result = result;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryEvaluationCriteriaResultCommonModel" /> class.
        /// </summary>
        public ConversationHistoryEvaluationCriteriaResultCommonModel()
        {
        }
    }
}