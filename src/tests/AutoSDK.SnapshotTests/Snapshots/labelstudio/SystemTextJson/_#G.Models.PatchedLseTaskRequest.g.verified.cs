//HintName: G.Models.PatchedLseTaskRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data Manager Task Serializer with FSM state support.
    /// </summary>
    public sealed partial class PatchedLseTaskRequest
    {
        /// <summary>
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_skip")]
        public bool? AllowSkip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_lead_time")]
        public double? AvgLeadTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_annotations")]
        public int? CancelledAnnotations { get; set; }

        /// <summary>
        /// Number of comments in the task including all annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_exists")]
        public bool? DraftExists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inner_id")]
        public int? InnerId { get; set; }

        /// <summary>
        /// True if the number of annotations for this task is greater than or equal to the number of maximum_completions for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_labeled")]
        public bool? IsLabeled { get; set; }

        /// <summary>
        /// When the last comment was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_comment_updated_at")]
        public global::System.DateTime? LastCommentUpdatedAt { get; set; }

        /// <summary>
        /// Meta is user imported (uploaded) data and can be useful as input for an ML Backend for embeddings, advanced vectors, and other info. It is passed to ML during training/predicting steps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Number of distinct annotators that processed the current task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap")]
        public int? Overlap { get; set; }

        /// <summary>
        /// Average agreement score for the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precomputed_agreement")]
        public double? PrecomputedAgreement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions_score")]
        public double? PredictionsScore { get; set; }

        /// <summary>
        /// Project ID for this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed")]
        public bool? Reviewed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviews_accepted")]
        public int? ReviewsAccepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviews_rejected")]
        public int? ReviewsRejected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_annotations")]
        public int? TotalAnnotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        /// Number of unresolved comments in the task including all annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unresolved_comment_count")]
        public int? UnresolvedCommentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseTaskRequest" /> class.
        /// </summary>
        /// <param name="allowSkip">
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </param>
        /// <param name="avgLeadTime"></param>
        /// <param name="cancelledAnnotations"></param>
        /// <param name="commentCount">
        /// Number of comments in the task including all annotations
        /// </param>
        /// <param name="completedAt"></param>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="draftExists"></param>
        /// <param name="groundTruth"></param>
        /// <param name="innerId"></param>
        /// <param name="isLabeled">
        /// True if the number of annotations for this task is greater than or equal to the number of maximum_completions for the project
        /// </param>
        /// <param name="lastCommentUpdatedAt">
        /// When the last comment was updated
        /// </param>
        /// <param name="meta">
        /// Meta is user imported (uploaded) data and can be useful as input for an ML Backend for embeddings, advanced vectors, and other info. It is passed to ML during training/predicting steps.
        /// </param>
        /// <param name="overlap">
        /// Number of distinct annotators that processed the current task
        /// </param>
        /// <param name="precomputedAgreement">
        /// Average agreement score for the task
        /// </param>
        /// <param name="predictionsScore"></param>
        /// <param name="project">
        /// Project ID for this task
        /// </param>
        /// <param name="reviewed"></param>
        /// <param name="reviewsAccepted"></param>
        /// <param name="reviewsRejected"></param>
        /// <param name="totalAnnotations"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="unresolvedCommentCount">
        /// Number of unresolved comments in the task including all annotations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLseTaskRequest(
            bool? allowSkip,
            double? avgLeadTime,
            int? cancelledAnnotations,
            int? commentCount,
            global::System.DateTime? completedAt,
            object? data,
            bool? draftExists,
            bool? groundTruth,
            int? innerId,
            bool? isLabeled,
            global::System.DateTime? lastCommentUpdatedAt,
            object? meta,
            int? overlap,
            double? precomputedAgreement,
            double? predictionsScore,
            int? project,
            bool? reviewed,
            int? reviewsAccepted,
            int? reviewsRejected,
            int? totalAnnotations,
            int? totalPredictions,
            int? unresolvedCommentCount)
        {
            this.AllowSkip = allowSkip;
            this.AvgLeadTime = avgLeadTime;
            this.CancelledAnnotations = cancelledAnnotations;
            this.CommentCount = commentCount;
            this.CompletedAt = completedAt;
            this.Data = data;
            this.DraftExists = draftExists;
            this.GroundTruth = groundTruth;
            this.InnerId = innerId;
            this.IsLabeled = isLabeled;
            this.LastCommentUpdatedAt = lastCommentUpdatedAt;
            this.Meta = meta;
            this.Overlap = overlap;
            this.PrecomputedAgreement = precomputedAgreement;
            this.PredictionsScore = predictionsScore;
            this.Project = project;
            this.Reviewed = reviewed;
            this.ReviewsAccepted = reviewsAccepted;
            this.ReviewsRejected = reviewsRejected;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
            this.UnresolvedCommentCount = unresolvedCommentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLseTaskRequest" /> class.
        /// </summary>
        public PatchedLseTaskRequest()
        {
        }
    }
}