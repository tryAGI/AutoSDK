//HintName: G.Models.TraceThread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_model_id")]
        public global::System.Guid? ThreadModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonListStringJsonConverter))]
        public global::G.JsonListString? FirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonListStringJsonConverter))]
        public global::G.JsonListString? LastMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScore>? FeedbackScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TraceThreadStatusJsonConverter))]
        public global::G.TraceThreadStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_messages")]
        public long? NumberOfMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::System.Collections.Generic.Dictionary<string, long>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<global::G.Comment>? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThread" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="threadModelId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="duration"></param>
        /// <param name="firstMessage"></param>
        /// <param name="lastMessage"></param>
        /// <param name="feedbackScores"></param>
        /// <param name="status"></param>
        /// <param name="numberOfMessages"></param>
        /// <param name="totalEstimatedCost"></param>
        /// <param name="usage"></param>
        /// <param name="comments"></param>
        /// <param name="tags"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceThread(
            string? id,
            global::System.Guid? projectId,
            global::System.Guid? threadModelId,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            double? duration,
            global::G.JsonListString? firstMessage,
            global::G.JsonListString? lastMessage,
            global::System.Collections.Generic.IList<global::G.FeedbackScore>? feedbackScores,
            global::G.TraceThreadStatus? status,
            long? numberOfMessages,
            double? totalEstimatedCost,
            global::System.Collections.Generic.Dictionary<string, long>? usage,
            global::System.Collections.Generic.IList<global::G.Comment>? comments,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            string? createdBy,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.ThreadModelId = threadModelId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.FirstMessage = firstMessage;
            this.LastMessage = lastMessage;
            this.FeedbackScores = feedbackScores;
            this.Status = status;
            this.NumberOfMessages = numberOfMessages;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.Usage = usage;
            this.Comments = comments;
            this.Tags = tags;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceThread" /> class.
        /// </summary>
        public TraceThread()
        {
        }
    }
}