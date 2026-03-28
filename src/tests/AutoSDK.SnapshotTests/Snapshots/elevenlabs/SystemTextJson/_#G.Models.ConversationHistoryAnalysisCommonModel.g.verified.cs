//HintName: G.Models.ConversationHistoryAnalysisCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryAnalysisCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria_results")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? EvaluationCriteriaResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_results")]
        public global::System.Collections.Generic.Dictionary<string, global::G.DataCollectionResultCommonModel>? DataCollectionResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria_results_list")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? EvaluationCriteriaResultsList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_results_list")]
        public global::System.Collections.Generic.IList<global::G.DataCollectionResultCommonModel>? DataCollectionResultsList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_successful")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluationSuccessResult CallSuccessful { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_summary_title")]
        public string? CallSummaryTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        /// <param name="callSuccessful"></param>
        /// <param name="transcriptSummary"></param>
        /// <param name="evaluationCriteriaResults"></param>
        /// <param name="dataCollectionResults"></param>
        /// <param name="evaluationCriteriaResultsList"></param>
        /// <param name="dataCollectionResultsList"></param>
        /// <param name="callSummaryTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryAnalysisCommonModel(
            global::G.EvaluationSuccessResult callSuccessful,
            string transcriptSummary,
            global::System.Collections.Generic.Dictionary<string, global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? evaluationCriteriaResults,
            global::System.Collections.Generic.Dictionary<string, global::G.DataCollectionResultCommonModel>? dataCollectionResults,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? evaluationCriteriaResultsList,
            global::System.Collections.Generic.IList<global::G.DataCollectionResultCommonModel>? dataCollectionResultsList,
            string? callSummaryTitle)
        {
            this.EvaluationCriteriaResults = evaluationCriteriaResults;
            this.DataCollectionResults = dataCollectionResults;
            this.EvaluationCriteriaResultsList = evaluationCriteriaResultsList;
            this.DataCollectionResultsList = dataCollectionResultsList;
            this.CallSuccessful = callSuccessful;
            this.TranscriptSummary = transcriptSummary ?? throw new global::System.ArgumentNullException(nameof(transcriptSummary));
            this.CallSummaryTitle = callSummaryTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        public ConversationHistoryAnalysisCommonModel()
        {
        }
    }
}