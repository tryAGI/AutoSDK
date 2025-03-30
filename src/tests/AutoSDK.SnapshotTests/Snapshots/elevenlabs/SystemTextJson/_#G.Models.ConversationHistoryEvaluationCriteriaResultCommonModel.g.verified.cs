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
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriteriaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluationSuccessResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryEvaluationCriteriaResultCommonModel" /> class.
        /// </summary>
        /// <param name="criteriaId"></param>
        /// <param name="result"></param>
        /// <param name="rationale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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