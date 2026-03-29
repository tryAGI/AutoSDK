//HintName: G.Models.PaginatedRoleBasedTaskList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedRoleBasedTaskList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RoleBasedTask> Tasks { get; set; }

        /// <summary>
        /// Total number of tasks<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Total number of annotations<br/>
        /// Example: 456
        /// </summary>
        /// <example>456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAnnotations { get; set; }

        /// <summary>
        /// Total number of predictions<br/>
        /// Example: 78
        /// </summary>
        /// <example>78</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPredictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedRoleBasedTaskList" /> class.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="total">
        /// Total number of tasks<br/>
        /// Example: 123
        /// </param>
        /// <param name="totalAnnotations">
        /// Total number of annotations<br/>
        /// Example: 456
        /// </param>
        /// <param name="totalPredictions">
        /// Total number of predictions<br/>
        /// Example: 78
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedRoleBasedTaskList(
            global::System.Collections.Generic.IList<global::G.RoleBasedTask> tasks,
            int total,
            int totalAnnotations,
            int totalPredictions)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Total = total;
            this.TotalAnnotations = totalAnnotations;
            this.TotalPredictions = totalPredictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedRoleBasedTaskList" /> class.
        /// </summary>
        public PaginatedRoleBasedTaskList()
        {
        }
    }
}