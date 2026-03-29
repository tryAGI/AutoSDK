//HintName: G.Models.AnnotationBulkSerializerWithSelectedItemsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Annotation Serializer with FSM state support.<br/>
    /// Note: The 'state' field will be populated from the queryset annotation<br/>
    /// if present, preventing N+1 queries. Use .with_state() on your queryset.
    /// </summary>
    public sealed partial class AnnotationBulkSerializerWithSelectedItemsRequest
    {
        /// <summary>
        /// Annotation was created in bulk mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk_created")]
        public bool? BulkCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_by")]
        public int? CompletedBy { get; set; }

        /// <summary>
        /// Draft creation time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_created_at")]
        public global::System.DateTime? DraftCreatedAt { get; set; }

        /// <summary>
        /// This annotation is a Ground Truth (ground_truth)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// Original annotation ID that was at the import step or NULL if this annotation wasn't imported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_id")]
        public long? ImportId { get; set; }

        /// <summary>
        /// Action which was performed in the last annotation history item<br/>
        /// * `prediction` - Created from prediction<br/>
        /// * `propagated_annotation` - Created from another annotation<br/>
        /// * `imported` - Imported<br/>
        /// * `submitted` - Submitted<br/>
        /// * `updated` - Updated<br/>
        /// * `skipped` - Skipped<br/>
        /// * `accepted` - Accepted<br/>
        /// * `rejected` - Rejected<br/>
        /// * `fixed_and_accepted` - Fixed and accepted<br/>
        /// * `deleted_review` - Deleted review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LastActionEnumJsonConverter))]
        public global::G.LastActionEnum? LastAction { get; set; }

        /// <summary>
        /// User who created the last annotation history item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_created_by")]
        public int? LastCreatedBy { get; set; }

        /// <summary>
        /// How much time it took to annotate the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lead_time")]
        public double? LeadTime { get; set; }

        /// <summary>
        /// Points to the parent annotation from which this annotation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_annotation")]
        public int? ParentAnnotation { get; set; }

        /// <summary>
        /// Points to the prediction from which this annotation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_prediction")]
        public int? ParentPrediction { get; set; }

        /// <summary>
        /// Project ID for this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// List of annotation results for the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_items")]
        public global::G.SelectedItemsRequest? SelectedItems { get; set; }

        /// <summary>
        /// Corresponding task for this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::System.Collections.Generic.IList<int>? Tasks { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Last user who updated this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// User skipped the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("was_cancelled")]
        public bool? WasCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationBulkSerializerWithSelectedItemsRequest" /> class.
        /// </summary>
        /// <param name="bulkCreated">
        /// Annotation was created in bulk mode
        /// </param>
        /// <param name="completedBy"></param>
        /// <param name="draftCreatedAt">
        /// Draft creation time
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth (ground_truth)
        /// </param>
        /// <param name="importId">
        /// Original annotation ID that was at the import step or NULL if this annotation wasn't imported
        /// </param>
        /// <param name="lastAction">
        /// Action which was performed in the last annotation history item<br/>
        /// * `prediction` - Created from prediction<br/>
        /// * `propagated_annotation` - Created from another annotation<br/>
        /// * `imported` - Imported<br/>
        /// * `submitted` - Submitted<br/>
        /// * `updated` - Updated<br/>
        /// * `skipped` - Skipped<br/>
        /// * `accepted` - Accepted<br/>
        /// * `rejected` - Rejected<br/>
        /// * `fixed_and_accepted` - Fixed and accepted<br/>
        /// * `deleted_review` - Deleted review
        /// </param>
        /// <param name="lastCreatedBy">
        /// User who created the last annotation history item
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task
        /// </param>
        /// <param name="parentAnnotation">
        /// Points to the parent annotation from which this annotation was created
        /// </param>
        /// <param name="parentPrediction">
        /// Points to the prediction from which this annotation was created
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// List of annotation results for the task
        /// </param>
        /// <param name="selectedItems"></param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="tasks"></param>
        /// <param name="uniqueId">
        /// Included only in requests
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationBulkSerializerWithSelectedItemsRequest(
            bool? bulkCreated,
            int? completedBy,
            global::System.DateTime? draftCreatedAt,
            bool? groundTruth,
            long? importId,
            global::G.LastActionEnum? lastAction,
            int? lastCreatedBy,
            double? leadTime,
            int? parentAnnotation,
            int? parentPrediction,
            int? project,
            global::System.Collections.Generic.IList<object>? result,
            global::G.SelectedItemsRequest? selectedItems,
            int? task,
            global::System.Collections.Generic.IList<int>? tasks,
            string? uniqueId,
            int? updatedBy,
            bool? wasCancelled)
        {
            this.BulkCreated = bulkCreated;
            this.CompletedBy = completedBy;
            this.DraftCreatedAt = draftCreatedAt;
            this.GroundTruth = groundTruth;
            this.ImportId = importId;
            this.LastAction = lastAction;
            this.LastCreatedBy = lastCreatedBy;
            this.LeadTime = leadTime;
            this.ParentAnnotation = parentAnnotation;
            this.ParentPrediction = parentPrediction;
            this.Project = project;
            this.Result = result;
            this.SelectedItems = selectedItems;
            this.Task = task;
            this.Tasks = tasks;
            this.UniqueId = uniqueId;
            this.UpdatedBy = updatedBy;
            this.WasCancelled = wasCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationBulkSerializerWithSelectedItemsRequest" /> class.
        /// </summary>
        public AnnotationBulkSerializerWithSelectedItemsRequest()
        {
        }
    }
}