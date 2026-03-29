//HintName: G.Models.ExperimentItemBulkRecordExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkRecordExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetItemId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluate_task_result")]
        public global::G.JsonListStringExperimentItemBulkWriteView? EvaluateTaskResult { get; set; }

        /// <summary>
        /// Please provide either none, only one of evaluate_task_result or trace, but never both
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace")]
        public global::G.TraceExperimentItemBulkWriteView? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans")]
        public global::System.Collections.Generic.IList<global::G.SpanExperimentItemBulkWriteView>? Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreExperimentItemBulkWriteView>? FeedbackScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecordExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="datasetItemId"></param>
        /// <param name="evaluateTaskResult"></param>
        /// <param name="trace">
        /// Please provide either none, only one of evaluate_task_result or trace, but never both
        /// </param>
        /// <param name="spans"></param>
        /// <param name="feedbackScores"></param>
        public ExperimentItemBulkRecordExperimentItemBulkWriteView(
            global::System.Guid datasetItemId,
            global::G.JsonListStringExperimentItemBulkWriteView? evaluateTaskResult,
            global::G.TraceExperimentItemBulkWriteView? trace,
            global::System.Collections.Generic.IList<global::G.SpanExperimentItemBulkWriteView>? spans,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreExperimentItemBulkWriteView>? feedbackScores)
        {
            this.DatasetItemId = datasetItemId;
            this.EvaluateTaskResult = evaluateTaskResult;
            this.Trace = trace;
            this.Spans = spans;
            this.FeedbackScores = feedbackScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecordExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ExperimentItemBulkRecordExperimentItemBulkWriteView()
        {
        }
    }
}