//HintName: G.Models.ProjectReimport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectReimport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_count")]
        public int? AnnotationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_columns")]
        public object? DataColumns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload_ids")]
        public object? FileUploadIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_as_tasks_list")]
        public bool? FilesAsTasksList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found_formats")]
        public object? FoundFormats { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_count")]
        public int? PredictionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Status7bfEnumJsonConverter))]
        public global::G.Status7bfEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_count")]
        public int? TaskCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReimport" /> class.
        /// </summary>
        /// <param name="annotationCount"></param>
        /// <param name="dataColumns"></param>
        /// <param name="duration"></param>
        /// <param name="error"></param>
        /// <param name="fileUploadIds"></param>
        /// <param name="filesAsTasksList"></param>
        /// <param name="foundFormats"></param>
        /// <param name="predictionCount"></param>
        /// <param name="project"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </param>
        /// <param name="taskCount"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectReimport(
            int? annotationCount,
            object? dataColumns,
            int? duration,
            string? error,
            object? fileUploadIds,
            bool? filesAsTasksList,
            object? foundFormats,
            int? predictionCount,
            int? project,
            global::G.Status7bfEnum? status,
            int? taskCount,
            int id = default!)
        {
            this.AnnotationCount = annotationCount;
            this.DataColumns = dataColumns;
            this.Duration = duration;
            this.Error = error;
            this.FileUploadIds = fileUploadIds;
            this.FilesAsTasksList = filesAsTasksList;
            this.FoundFormats = foundFormats;
            this.Id = id;
            this.PredictionCount = predictionCount;
            this.Project = project;
            this.Status = status;
            this.TaskCount = taskCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectReimport" /> class.
        /// </summary>
        public ProjectReimport()
        {
        }
    }
}