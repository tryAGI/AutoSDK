//HintName: G.Models.ExperimentItemBulkRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkRecord
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
        public global::G.JsonListString? EvaluateTaskResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace")]
        public global::G.Trace? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans")]
        public global::System.Collections.Generic.IList<global::G.Span>? Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScore>? FeedbackScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecord" /> class.
        /// </summary>
        /// <param name="datasetItemId"></param>
        /// <param name="evaluateTaskResult"></param>
        /// <param name="trace"></param>
        /// <param name="spans"></param>
        /// <param name="feedbackScores"></param>
        public ExperimentItemBulkRecord(
            global::System.Guid datasetItemId,
            global::G.JsonListString? evaluateTaskResult,
            global::G.Trace? trace,
            global::System.Collections.Generic.IList<global::G.Span>? spans,
            global::System.Collections.Generic.IList<global::G.FeedbackScore>? feedbackScores)
        {
            this.DatasetItemId = datasetItemId;
            this.EvaluateTaskResult = evaluateTaskResult;
            this.Trace = trace;
            this.Spans = spans;
            this.FeedbackScores = feedbackScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecord" /> class.
        /// </summary>
        public ExperimentItemBulkRecord()
        {
        }
    }
}