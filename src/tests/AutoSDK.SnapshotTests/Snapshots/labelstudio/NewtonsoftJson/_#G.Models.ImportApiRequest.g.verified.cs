//HintName: G.Models.ImportApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tasks serializer for Import API (TaskBulkCreateAPI)
    /// </summary>
    public sealed partial class ImportApiRequest
    {
        /// <summary>
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_skip")]
        public bool? AllowSkip { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::System.Collections.Generic.IList<global::G.AnnotationRequest>? Annotations { get; set; }

        /// <summary>
        /// Number of total cancelled annotations for the current task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled_annotations")]
        public int? CancelledAnnotations { get; set; }

        /// <summary>
        /// Users who wrote comments
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment_authors")]
        public global::System.Collections.Generic.IList<int>? CommentAuthors { get; set; }

        /// <summary>
        /// Number of comments in the task including all annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment_count")]
        public int? CommentCount { get; set; }

        /// <summary>
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// Uploaded file used as data source for this task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_upload")]
        public int? FileUpload { get; set; }

        /// <summary>
        /// Internal task ID in the project, starts with 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inner_id")]
        public long? InnerId { get; set; }

        /// <summary>
        /// When the last comment was updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_comment_updated_at")]
        public global::System.DateTime? LastCommentUpdatedAt { get; set; }

        /// <summary>
        /// Meta is user imported (uploaded) data and can be useful as input for an ML Backend for embeddings, advanced vectors, and other info. It is passed to ML during training/predicting steps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Number of distinct annotators that processed the current task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overlap")]
        public int? Overlap { get; set; }

        /// <summary>
        /// Average agreement score for the task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("precomputed_agreement")]
        public double? PrecomputedAgreement { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<global::G.PredictionRequest>? Predictions { get; set; }

        /// <summary>
        /// Number of total annotations for the current task except cancelled annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_annotations")]
        public int? TotalAnnotations { get; set; }

        /// <summary>
        /// Number of total predictions for the current task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        /// Number of unresolved comments in the task including all annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unresolved_comment_count")]
        public int? UnresolvedCommentCount { get; set; }

        /// <summary>
        /// Last annotator or reviewer who updated this task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="allowSkip">
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </param>
        /// <param name="annotations">
        /// Default Value: []
        /// </param>
        /// <param name="cancelledAnnotations">
        /// Number of total cancelled annotations for the current task
        /// </param>
        /// <param name="commentAuthors">
        /// Users who wrote comments
        /// </param>
        /// <param name="commentCount">
        /// Number of comments in the task including all annotations
        /// </param>
        /// <param name="fileUpload">
        /// Uploaded file used as data source for this task
        /// </param>
        /// <param name="innerId">
        /// Internal task ID in the project, starts with 1
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
        /// <param name="predictions">
        /// Default Value: []
        /// </param>
        /// <param name="totalAnnotations">
        /// Number of total annotations for the current task except cancelled annotations
        /// </param>
        /// <param name="totalPredictions">
        /// Number of total predictions for the current task
        /// </param>
        /// <param name="unresolvedCommentCount">
        /// Number of unresolved comments in the task including all annotations
        /// </param>
        /// <param name="updatedBy">
        /// Last annotator or reviewer who updated this task
        /// </param>
        public ImportApiRequest(
            object data,
            bool? allowSkip,
            global::System.Collections.Generic.IList<global::G.AnnotationRequest>? annotations,
            int? cancelledAnnotations,
            global::System.Collections.Generic.IList<int>? commentAuthors,
            int? commentCount,
            int? fileUpload,
            long? innerId,
            global::System.DateTime? lastCommentUpdatedAt,
            object? meta,
            int? overlap,
            double? precomputedAgreement,
            global::System.Collections.Generic.IList<global::G.PredictionRequest>? predictions,
            int? totalAnnotations,
            int? totalPredictions,
            int? unresolvedCommentCount,
            int? updatedBy)
        {
            this.AllowSkip = allowSkip;
            this.Annotations = annotations;
            this.CancelledAnnotations = cancelledAnnotations;
            this.CommentAuthors = commentAuthors;
            this.CommentCount = commentCount;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FileUpload = fileUpload;
            this.InnerId = innerId;
            this.LastCommentUpdatedAt = lastCommentUpdatedAt;
            this.Meta = meta;
            this.Overlap = overlap;
            this.PrecomputedAgreement = precomputedAgreement;
            this.Predictions = predictions;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
            this.UnresolvedCommentCount = unresolvedCommentCount;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportApiRequest" /> class.
        /// </summary>
        public ImportApiRequest()
        {
        }
    }
}