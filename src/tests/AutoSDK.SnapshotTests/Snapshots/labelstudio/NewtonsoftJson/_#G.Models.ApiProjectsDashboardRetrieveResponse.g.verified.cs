//HintName: G.Models.ApiProjectsDashboardRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsDashboardRetrieveResponse
    {
        /// <summary>
        /// Number of annotated (completed) tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotated_tasks")]
        public int? AnnotatedTasks { get; set; }

        /// <summary>
        /// Total number of annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public int? Annotations { get; set; }

        /// <summary>
        /// Total number of uncompleted tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining_tasks")]
        public int? RemainingTasks { get; set; }

        /// <summary>
        /// Number of tasks that have been reviewed by at least one reviewer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewed_tasks")]
        public int? ReviewedTasks { get; set; }

        /// <summary>
        /// Number of tasks that have been skipped by at least one annotator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipped_tasks")]
        public int? SkippedTasks { get; set; }

        /// <summary>
        /// Total number of tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tasks")]
        public int? Tasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsDashboardRetrieveResponse" /> class.
        /// </summary>
        /// <param name="annotatedTasks">
        /// Number of annotated (completed) tasks
        /// </param>
        /// <param name="annotations">
        /// Total number of annotations
        /// </param>
        /// <param name="remainingTasks">
        /// Total number of uncompleted tasks
        /// </param>
        /// <param name="reviewedTasks">
        /// Number of tasks that have been reviewed by at least one reviewer
        /// </param>
        /// <param name="skippedTasks">
        /// Number of tasks that have been skipped by at least one annotator
        /// </param>
        /// <param name="tasks">
        /// Total number of tasks
        /// </param>
        public ApiProjectsDashboardRetrieveResponse(
            int? annotatedTasks,
            int? annotations,
            int? remainingTasks,
            int? reviewedTasks,
            int? skippedTasks,
            int? tasks)
        {
            this.AnnotatedTasks = annotatedTasks;
            this.Annotations = annotations;
            this.RemainingTasks = remainingTasks;
            this.ReviewedTasks = reviewedTasks;
            this.SkippedTasks = skippedTasks;
            this.Tasks = tasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsDashboardRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsDashboardRetrieveResponse()
        {
        }
    }
}