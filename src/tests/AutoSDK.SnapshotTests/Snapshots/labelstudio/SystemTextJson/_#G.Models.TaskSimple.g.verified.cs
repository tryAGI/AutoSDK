//HintName: G.Models.TaskSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class TaskSimple
    {
        /// <summary>
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::G.Annotation> Annotations { get; set; } = default!;

        /// <summary>
        /// Number of total cancelled annotations for the current task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_annotations")]
        public int? CancelledAnnotations { get; set; }

        /// <summary>
        /// Users who wrote comments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_authors")]
        public global::System.Collections.Generic.IList<int>? CommentAuthors { get; set; }

        /// <summary>
        /// Number of comments in the task including all annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

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
        /// Uploaded file used as data source for this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        public int? FileUpload { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Internal task ID in the project, starts with 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inner_id")]
        public long? InnerId { get; set; }

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
        /// Default Value: []<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<global::G.Prediction> Predictions { get; set; } = default!;

        /// <summary>
        /// Project ID for this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Number of total annotations for the current task except cancelled annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_annotations")]
        public int? TotalAnnotations { get; set; }

        /// <summary>
        /// Number of total predictions for the current task
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
        /// Last annotator or reviewer who updated this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSimple" /> class.
        /// </summary>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
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
        /// <param name="project">
        /// Project ID for this task
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
        /// <param name="annotations">
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Time a task was created<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="predictions">
        /// Default Value: []<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last time a task was updated<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskSimple(
            object data,
            int? cancelledAnnotations,
            global::System.Collections.Generic.IList<int>? commentAuthors,
            int? commentCount,
            int? fileUpload,
            long? innerId,
            bool? isLabeled,
            global::System.DateTime? lastCommentUpdatedAt,
            object? meta,
            int? overlap,
            int? project,
            int? totalAnnotations,
            int? totalPredictions,
            int? unresolvedCommentCount,
            int? updatedBy,
            global::System.Collections.Generic.IList<global::G.Annotation> annotations = default!,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.Collections.Generic.IList<global::G.Prediction> predictions = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Annotations = annotations;
            this.CancelledAnnotations = cancelledAnnotations;
            this.CommentAuthors = commentAuthors;
            this.CommentCount = commentCount;
            this.CreatedAt = createdAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FileUpload = fileUpload;
            this.Id = id;
            this.InnerId = innerId;
            this.IsLabeled = isLabeled;
            this.LastCommentUpdatedAt = lastCommentUpdatedAt;
            this.Meta = meta;
            this.Overlap = overlap;
            this.Predictions = predictions;
            this.Project = project;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
            this.UnresolvedCommentCount = unresolvedCommentCount;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSimple" /> class.
        /// </summary>
        public TaskSimple()
        {
        }
    }
}