//HintName: G.Models.ExperimentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExperimentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetItemId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TraceId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.JsonListString? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.JsonListString? Output { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScore>? FeedbackScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.Comment>? Comments { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.Dictionary<string, long>? Usage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_visibility_mode")]
        public global::G.ExperimentItemTraceVisibilityMode? TraceVisibilityMode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assertion_results")]
        public global::System.Collections.Generic.IList<global::G.AssertionResult>? AssertionResults { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ExperimentItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="datasetItemId"></param>
        /// <param name="traceId"></param>
        /// <param name="id"></param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="feedbackScores">
        /// Included only in responses
        /// </param>
        /// <param name="comments">
        /// Included only in responses
        /// </param>
        /// <param name="totalEstimatedCost">
        /// Included only in responses
        /// </param>
        /// <param name="duration">
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="traceVisibilityMode">
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Included only in responses
        /// </param>
        /// <param name="assertionResults">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        public ExperimentItem(
            global::System.Guid experimentId,
            global::System.Guid datasetItemId,
            global::System.Guid traceId,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectName,
            global::G.JsonListString? input,
            global::G.JsonListString? output,
            global::System.Collections.Generic.IList<global::G.FeedbackScore>? feedbackScores,
            global::System.Collections.Generic.IList<global::G.Comment>? comments,
            double? totalEstimatedCost,
            double? duration,
            global::System.Collections.Generic.Dictionary<string, long>? usage,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy,
            global::G.ExperimentItemTraceVisibilityMode? traceVisibilityMode,
            string? description,
            global::System.Collections.Generic.IList<global::G.AssertionResult>? assertionResults,
            global::G.ExperimentItemStatus? status)
        {
            this.Id = id;
            this.ExperimentId = experimentId;
            this.DatasetItemId = datasetItemId;
            this.TraceId = traceId;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Input = input;
            this.Output = output;
            this.FeedbackScores = feedbackScores;
            this.Comments = comments;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.Duration = duration;
            this.Usage = usage;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
            this.TraceVisibilityMode = traceVisibilityMode;
            this.Description = description;
            this.AssertionResults = assertionResults;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItem" /> class.
        /// </summary>
        public ExperimentItem()
        {
        }
    }
}