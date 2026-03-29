//HintName: G.Models.ProjectSubsetTasksResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSubsetTasksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_cursor")]
        public string? PreviousCursor { get; set; }

        /// <summary>
        /// Present only when include_total=true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_count")]
        public int? TaskCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_result_list", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProjectSubsetTaskItem> TaskResultList { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetTasksResponse" /> class.
        /// </summary>
        /// <param name="taskResultList"></param>
        /// <param name="nextCursor"></param>
        /// <param name="previousCursor"></param>
        /// <param name="taskCount">
        /// Present only when include_total=true
        /// </param>
        public ProjectSubsetTasksResponse(
            global::System.Collections.Generic.IList<global::G.ProjectSubsetTaskItem> taskResultList,
            string? nextCursor,
            string? previousCursor,
            int? taskCount)
        {
            this.NextCursor = nextCursor;
            this.PreviousCursor = previousCursor;
            this.TaskCount = taskCount;
            this.TaskResultList = taskResultList ?? throw new global::System.ArgumentNullException(nameof(taskResultList));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetTasksResponse" /> class.
        /// </summary>
        public ProjectSubsetTasksResponse()
        {
        }
    }
}