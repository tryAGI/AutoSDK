//HintName: G.Models.TracePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public global::G.JsonListStringPublic? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.JsonListStringPublic? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListStringPublic? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_info")]
        public global::G.ErrorInfoPublic? ErrorInfo { get; set; }

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
        /// 
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
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScorePublic>? FeedbackScores { get; set; }

        /// <summary>
        /// Aggregated feedback scores from all spans in this trace, averaged by score name<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScorePublic>? SpanFeedbackScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.CommentPublic>? Comments { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_validations")]
        public global::System.Collections.Generic.IList<global::G.GuardrailsValidationPublic>? GuardrailsValidations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_count")]
        public int? SpanCount { get; set; }

        /// <summary>
        /// Duration in milliseconds as a decimal number to support sub-millisecond precision<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Time to first token in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft")]
        public double? Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TracePublicVisibilityModeJsonConverter))]
        public global::G.TracePublicVisibilityMode? VisibilityMode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_span_count")]
        public int? LlmSpanCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_tool_spans")]
        public bool? HasToolSpans { get; set; }

        /// <summary>
        /// List of unique provider names from all spans in this trace, sorted alphabetically<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providers")]
        public global::System.Collections.Generic.IList<string>? Providers { get; set; }

        /// <summary>
        /// Experiment reference with ID, name, dataset ID, and dataset item ID<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment")]
        public global::G.ExperimentItemReferencePublic? Experiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TracePublicSourceJsonConverter))]
        public global::G.TracePublicSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracePublic" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="id"></param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="errorInfo"></param>
        /// <param name="usage">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="feedbackScores">
        /// Included only in responses
        /// </param>
        /// <param name="spanFeedbackScores">
        /// Aggregated feedback scores from all spans in this trace, averaged by score name<br/>
        /// Included only in responses
        /// </param>
        /// <param name="comments">
        /// Included only in responses
        /// </param>
        /// <param name="guardrailsValidations">
        /// Included only in responses
        /// </param>
        /// <param name="totalEstimatedCost">
        /// Included only in responses
        /// </param>
        /// <param name="spanCount">
        /// Included only in responses
        /// </param>
        /// <param name="duration">
        /// Duration in milliseconds as a decimal number to support sub-millisecond precision<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="threadId"></param>
        /// <param name="visibilityMode">
        /// Included only in responses
        /// </param>
        /// <param name="llmSpanCount">
        /// Included only in responses
        /// </param>
        /// <param name="hasToolSpans">
        /// Included only in responses
        /// </param>
        /// <param name="providers">
        /// List of unique provider names from all spans in this trace, sorted alphabetically<br/>
        /// Included only in responses
        /// </param>
        /// <param name="experiment">
        /// Experiment reference with ID, name, dataset ID, and dataset item ID<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source"></param>
        public TracePublic(
            global::System.DateTime startTime,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? name,
            global::System.DateTime? endTime,
            global::G.JsonListStringPublic? input,
            global::G.JsonListStringPublic? output,
            global::G.JsonListStringPublic? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ErrorInfoPublic? errorInfo,
            global::System.Collections.Generic.Dictionary<string, long>? usage,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy,
            global::System.Collections.Generic.IList<global::G.FeedbackScorePublic>? feedbackScores,
            global::System.Collections.Generic.IList<global::G.FeedbackScorePublic>? spanFeedbackScores,
            global::System.Collections.Generic.IList<global::G.CommentPublic>? comments,
            global::System.Collections.Generic.IList<global::G.GuardrailsValidationPublic>? guardrailsValidations,
            double? totalEstimatedCost,
            int? spanCount,
            double? duration,
            double? ttft,
            string? threadId,
            global::G.TracePublicVisibilityMode? visibilityMode,
            int? llmSpanCount,
            bool? hasToolSpans,
            global::System.Collections.Generic.IList<string>? providers,
            global::G.ExperimentItemReferencePublic? experiment,
            global::G.TracePublicSource? source)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.Tags = tags;
            this.ErrorInfo = errorInfo;
            this.Usage = usage;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
            this.FeedbackScores = feedbackScores;
            this.SpanFeedbackScores = spanFeedbackScores;
            this.Comments = comments;
            this.GuardrailsValidations = guardrailsValidations;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.SpanCount = spanCount;
            this.Duration = duration;
            this.Ttft = ttft;
            this.ThreadId = threadId;
            this.VisibilityMode = visibilityMode;
            this.LlmSpanCount = llmSpanCount;
            this.HasToolSpans = hasToolSpans;
            this.Providers = providers;
            this.Experiment = experiment;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracePublic" /> class.
        /// </summary>
        public TracePublic()
        {
        }
    }
}