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
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::System.Collections.Generic.IList<global::G.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat>? Stats { get; set; }

        /// <summary>
        /// Default filter tab for tasks with annotations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks_with_annotations")]
        public object? TasksWithAnnotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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