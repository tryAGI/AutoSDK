//HintName: G.Models.LseTaskSerializerForReviewers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data Manager Task Serializer with FSM state support.
    /// </summary>
    public sealed partial class LseTaskSerializerForReviewers
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement")]
        public string Agreement { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_selected")]
        public string AgreementSelected { get; set; } = default!;

        /// <summary>
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_skip")]
        public bool? AllowSkip { get; set; }

        /// <summary>
        /// Calculate total annotation time for this task from MetricInTimeBucket records.<br/>
        /// Returns time in seconds.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_time")]
        public int AnnotationTime { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public string Annotations { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations_ids")]
        public string AnnotationsIds { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations_results")]
        public string AnnotationsResults { get; set; } = default!;

        /// <summary>
        /// Annotators IDs who annotated this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotators")]
        public global::System.Collections.Generic.IList<int> Annotators { get; set; } = default!;

        /// <summary>
        /// The annotators_count is calculated as the number of users with annotations (can be repeated, so same as the number of annotations) + the number of assignees without annotations.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotators_count")]
        public int AnnotatorsCount { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_authors")]
        public global::System.Collections.Generic.IList<object> CommentAuthors { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_authors_count")]
        public int CommentAuthorsCount { get; set; } = default!;

        /// <summary>
        /// Number of comments in the task including all annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public string Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Time a task was created<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_exists")]
        public bool? DraftExists { get; set; }

        /// <summary>
        /// Drafts for this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("drafts")]
        public global::System.Collections.Generic.IList<global::G.LseTaskSerializerForReviewersDraft> Drafts { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        public string FileUpload { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        /// Predictions for this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<global::G.LseTaskSerializerForReviewersPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions_model_versions")]
        public string PredictionsModelVersions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions_results")]
        public string PredictionsResults { get; set; } = default!;

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
        /// Calculate total review time for this task from MetricInTimeBucket records.<br/>
        /// Returns time in seconds.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_time")]
        public int ReviewTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed")]
        public bool? Reviewed { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<object> Reviewers { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers_count")]
        public int ReviewersCount { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_filename")]
        public string StorageFilename { get; set; } = default!;

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
        /// Last time a task was updated<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// User IDs who updated this task<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::System.Collections.Generic.IList<object> UpdatedBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewers" /> class.
        /// </summary>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="allowSkip">
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </param>
        /// <param name="avgLeadTime"></param>
        /// <param name="cancelledAnnotations"></param>
        /// <param name="commentCount">
        /// Number of comments in the task including all annotations
        /// </param>
        /// <param name="completedAt"></param>
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
        /// <param name="agreement">
        /// Included only in responses
        /// </param>
        /// <param name="agreementSelected">
        /// Included only in responses
        /// </param>
        /// <param name="annotationTime">
        /// Calculate total annotation time for this task from MetricInTimeBucket records.<br/>
        /// Returns time in seconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="annotations">
        /// Included only in responses
        /// </param>
        /// <param name="annotationsIds">
        /// Included only in responses
        /// </param>
        /// <param name="annotationsResults">
        /// Included only in responses
        /// </param>
        /// <param name="annotators">
        /// Annotators IDs who annotated this task<br/>
        /// Included only in responses
        /// </param>
        /// <param name="annotatorsCount">
        /// The annotators_count is calculated as the number of users with annotations (can be repeated, so same as the number of annotations) + the number of assignees without annotations.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="commentAuthors">
        /// Included only in responses
        /// </param>
        /// <param name="commentAuthorsCount">
        /// Included only in responses
        /// </param>
        /// <param name="comments">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Time a task was created<br/>
        /// Included only in responses
        /// </param>
        /// <param name="drafts">
        /// Drafts for this task<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileUpload">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="predictions">
        /// Predictions for this task<br/>
        /// Included only in responses
        /// </param>
        /// <param name="predictionsModelVersions">
        /// Included only in responses
        /// </param>
        /// <param name="predictionsResults">
        /// Included only in responses
        /// </param>
        /// <param name="reviewTime">
        /// Calculate total review time for this task from MetricInTimeBucket records.<br/>
        /// Returns time in seconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="reviewers">
        /// Included only in responses
        /// </param>
        /// <param name="reviewersCount">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        /// <param name="storageFilename">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last time a task was updated<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedBy">
        /// User IDs who updated this task<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseTaskSerializerForReviewers(
            object data,
            bool? allowSkip,
            double? avgLeadTime,
            int? cancelledAnnotations,
            int? commentCount,
            global::System.DateTime? completedAt,
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
            int? unresolvedCommentCount,
            string agreement = default!,
            string agreementSelected = default!,
            int annotationTime = default!,
            string annotations = default!,
            string annotationsIds = default!,
            string annotationsResults = default!,
            global::System.Collections.Generic.IList<int> annotators = default!,
            int annotatorsCount = default!,
            global::System.Collections.Generic.IList<object> commentAuthors = default!,
            int commentAuthorsCount = default!,
            string comments = default!,
            global::System.DateTime createdAt = default!,
            global::System.Collections.Generic.IList<global::G.LseTaskSerializerForReviewersDraft> drafts = default!,
            string fileUpload = default!,
            int id = default!,
            global::System.Collections.Generic.IList<global::G.LseTaskSerializerForReviewersPrediction> predictions = default!,
            string predictionsModelVersions = default!,
            string predictionsResults = default!,
            int reviewTime = default!,
            global::System.Collections.Generic.IList<object> reviewers = default!,
            int reviewersCount = default!,
            string state = default!,
            string storageFilename = default!,
            global::System.DateTime updatedAt = default!,
            global::System.Collections.Generic.IList<object> updatedBy = default!)
        {
            this.Agreement = agreement;
            this.AgreementSelected = agreementSelected;
            this.AllowSkip = allowSkip;
            this.AnnotationTime = annotationTime;
            this.Annotations = annotations;
            this.AnnotationsIds = annotationsIds;
            this.AnnotationsResults = annotationsResults;
            this.Annotators = annotators;
            this.AnnotatorsCount = annotatorsCount;
            this.AvgLeadTime = avgLeadTime;
            this.CancelledAnnotations = cancelledAnnotations;
            this.CommentAuthors = commentAuthors;
            this.CommentAuthorsCount = commentAuthorsCount;
            this.CommentCount = commentCount;
            this.Comments = comments;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.DraftExists = draftExists;
            this.Drafts = drafts;
            this.FileUpload = fileUpload;
            this.GroundTruth = groundTruth;
            this.Id = id;
            this.InnerId = innerId;
            this.IsLabeled = isLabeled;
            this.LastCommentUpdatedAt = lastCommentUpdatedAt;
            this.Meta = meta;
            this.Overlap = overlap;
            this.PrecomputedAgreement = precomputedAgreement;
            this.Predictions = predictions;
            this.PredictionsModelVersions = predictionsModelVersions;
            this.PredictionsResults = predictionsResults;
            this.PredictionsScore = predictionsScore;
            this.Project = project;
            this.ReviewTime = reviewTime;
            this.Reviewed = reviewed;
            this.Reviewers = reviewers;
            this.ReviewersCount = reviewersCount;
            this.ReviewsAccepted = reviewsAccepted;
            this.ReviewsRejected = reviewsRejected;
            this.State = state;
            this.StorageFilename = storageFilename;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
            this.UnresolvedCommentCount = unresolvedCommentCount;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewers" /> class.
        /// </summary>
        public LseTaskSerializerForReviewers()
        {
        }
    }
}