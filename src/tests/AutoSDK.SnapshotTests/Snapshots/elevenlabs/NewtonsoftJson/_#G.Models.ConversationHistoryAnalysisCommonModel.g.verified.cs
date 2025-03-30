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
        [global::Newtonsoft.Json.JsonProperty("evaluation_criteria_results")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? EvaluationCriteriaResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_collection_results")]
        public global::System.Collections.Generic.Dictionary<string, global::G.DataCollectionResultCommonModel>? DataCollectionResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_successful", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluationSuccessResult CallSuccessful { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string TranscriptSummary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        /// <param name="evaluationCriteriaResults"></param>
        /// <param name="dataCollectionResults"></param>
        /// <param name="callSuccessful"></param>
        /// <param name="transcriptSummary"></param>
        public ConversationHistoryAnalysisCommonModel(
            global::G.EvaluationSuccessResult callSuccessful,
            string transcriptSummary,
            global::System.Collections.Generic.Dictionary<string, global::G.ConversationHistoryEvaluationCriteriaResultCommonModel>? evaluationCriteriaResults,
            global::System.Collections.Generic.Dictionary<string, global::G.DataCollectionResultCommonModel>? dataCollectionResults)
        {
            this.CallSuccessful = callSuccessful;
            this.TranscriptSummary = transcriptSummary ?? throw new global::System.ArgumentNullException(nameof(transcriptSummary));
            this.EvaluationCriteriaResults = evaluationCriteriaResults;
            this.DataCollectionResults = dataCollectionResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryAnalysisCommonModel" /> class.
        /// </summary>
        public ConversationHistoryAnalysisCommonModel()
        {
        }
    }
}