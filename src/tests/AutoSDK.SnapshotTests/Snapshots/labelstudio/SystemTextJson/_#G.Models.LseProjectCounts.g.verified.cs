//HintName: G.Models.LseProjectCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer get numbers from project queryset annotation,<br/>
    /// make sure, that you use correct one(Project.objects.with_counts())
    /// </summary>
    public sealed partial class LseProjectCounts
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_task_number")]
        public int FinishedTaskNumber { get; set; } = default!;

        /// <summary>
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth_number")]
        public int GroundTruthNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_tasks_with_annotations")]
        public int? NumTasksWithAnnotations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_done")]
        public int QueueDone { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_left")]
        public int QueueLeft { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_total")]
        public string QueueTotal { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        public int Rejected { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_total_tasks")]
        public int ReviewTotalTasks { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_number")]
        public int ReviewedNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_annotations_number")]
        public string SkippedAnnotationsNumber { get; set; } = default!;

        /// <summary>
        /// Total task number in project<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_number")]
        public int TaskNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_annotations_number")]
        public string TotalAnnotationsNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions_number")]
        public int TotalPredictionsNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useful_annotation_number")]
        public int? UsefulAnnotationNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCounts" /> class.
        /// </summary>
        /// <param name="numTasksWithAnnotations">
        /// Included only in responses
        /// </param>
        /// <param name="usefulAnnotationNumber">
        /// Included only in responses
        /// </param>
        /// <param name="finishedTaskNumber">
        /// Included only in responses
        /// </param>
        /// <param name="groundTruthNumber">
        /// Honeypot annotation number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="queueDone">
        /// Included only in responses
        /// </param>
        /// <param name="queueLeft">
        /// Included only in responses
        /// </param>
        /// <param name="queueTotal">
        /// Included only in responses
        /// </param>
        /// <param name="rejected">
        /// Included only in responses
        /// </param>
        /// <param name="reviewTotalTasks">
        /// Included only in responses
        /// </param>
        /// <param name="reviewedNumber">
        /// Included only in responses
        /// </param>
        /// <param name="skippedAnnotationsNumber">
        /// Included only in responses
        /// </param>
        /// <param name="taskNumber">
        /// Total task number in project<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalAnnotationsNumber">
        /// Included only in responses
        /// </param>
        /// <param name="totalPredictionsNumber">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseProjectCounts(
            int? numTasksWithAnnotations,
            int? usefulAnnotationNumber,
            int finishedTaskNumber = default!,
            int groundTruthNumber = default!,
            int id = default!,
            int queueDone = default!,
            int queueLeft = default!,
            string queueTotal = default!,
            int rejected = default!,
            int reviewTotalTasks = default!,
            int reviewedNumber = default!,
            string skippedAnnotationsNumber = default!,
            int taskNumber = default!,
            string totalAnnotationsNumber = default!,
            int totalPredictionsNumber = default!)
        {
            this.FinishedTaskNumber = finishedTaskNumber;
            this.GroundTruthNumber = groundTruthNumber;
            this.Id = id;
            this.NumTasksWithAnnotations = numTasksWithAnnotations;
            this.QueueDone = queueDone;
            this.QueueLeft = queueLeft;
            this.QueueTotal = queueTotal;
            this.Rejected = rejected;
            this.ReviewTotalTasks = reviewTotalTasks;
            this.ReviewedNumber = reviewedNumber;
            this.SkippedAnnotationsNumber = skippedAnnotationsNumber;
            this.TaskNumber = taskNumber;
            this.TotalAnnotationsNumber = totalAnnotationsNumber;
            this.TotalPredictionsNumber = totalPredictionsNumber;
            this.UsefulAnnotationNumber = usefulAnnotationNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectCounts" /> class.
        /// </summary>
        public LseProjectCounts()
        {
        }
    }
}