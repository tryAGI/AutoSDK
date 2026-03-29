//HintName: G.Models.ApiProjectsStatsDataFilterRetrieveResponseUserFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data filter statistics by user and model
    /// </summary>
    public sealed partial class ApiProjectsStatsDataFilterRetrieveResponseUserFilters
    {
        /// <summary>
        /// List of filter configurations for users and models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::System.Collections.Generic.IList<global::G.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? Stats { get; set; }

        /// <summary>
        /// Default filter tab for tasks with annotations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tasks_with_annotations")]
        public object? TasksWithAnnotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponseUserFilters" /> class.
        /// </summary>
        /// <param name="stats">
        /// List of filter configurations for users and models
        /// </param>
        /// <param name="tasksWithAnnotations">
        /// Default filter tab for tasks with annotations
        /// </param>
        public ApiProjectsStatsDataFilterRetrieveResponseUserFilters(
            global::System.Collections.Generic.IList<global::G.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? stats,
            object? tasksWithAnnotations)
        {
            this.Stats = stats;
            this.TasksWithAnnotations = tasksWithAnnotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponseUserFilters" /> class.
        /// </summary>
        public ApiProjectsStatsDataFilterRetrieveResponseUserFilters()
        {
        }
    }
}