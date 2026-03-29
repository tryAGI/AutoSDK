//HintName: G.Models.ProjectImport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectImport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_count")]
        public int? AnnotationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_to_project")]
        public bool? CommitToProject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("could_be_tasks_list")]
        public bool? CouldBeTasksList { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
        /// Complete or fail time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("preannotated_from_fields")]
        public object? PreannotatedFromFields { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_task_ids")]
        public bool? ReturnTaskIds { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public object? TaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public object? Tasks { get; set; }

        /// <summary>
        /// Updated time<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImport" /> class.
        /// </summary>
        /// <param name="annotationCount"></param>
        /// <param name="commitToProject"></param>
        /// <param name="couldBeTasksList"></param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataColumns"></param>
        /// <param name="duration"></param>
        /// <param name="error"></param>
        /// <param name="fileUploadIds"></param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="foundFormats"></param>
        /// <param name="preannotatedFromFields"></param>
        /// <param name="predictionCount"></param>
        /// <param name="project"></param>
        /// <param name="returnTaskIds"></param>
        /// <param name="status">
        /// * `created` - Created<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed
        /// </param>
        /// <param name="taskCount"></param>
        /// <param name="taskIds"></param>
        /// <param name="tasks"></param>
        /// <param name="updatedAt">
        /// Updated time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectImport(
            int? annotationCount,
            bool? commitToProject,
            bool? couldBeTasksList,
            global::System.DateTime? createdAt,
            object? dataColumns,
            int? duration,
            string? error,
            object? fileUploadIds,
            global::System.DateTime? finishedAt,
            object? foundFormats,
            object? preannotatedFromFields,
            int? predictionCount,
            int? project,
            bool? returnTaskIds,
            global::G.Status7bfEnum? status,
            int? taskCount,
            object? taskIds,
            object? tasks,
            global::System.DateTime? updatedAt,
            string? url,
            int id = default!)
        {
            this.AnnotationCount = annotationCount;
            this.CommitToProject = commitToProject;
            this.CouldBeTasksList = couldBeTasksList;
            this.CreatedAt = createdAt;
            this.DataColumns = dataColumns;
            this.Duration = duration;
            this.Error = error;
            this.FileUploadIds = fileUploadIds;
            this.FinishedAt = finishedAt;
            this.FoundFormats = foundFormats;
            this.Id = id;
            this.PreannotatedFromFields = preannotatedFromFields;
            this.PredictionCount = predictionCount;
            this.Project = project;
            this.ReturnTaskIds = returnTaskIds;
            this.Status = status;
            this.TaskCount = taskCount;
            this.TaskIds = taskIds;
            this.Tasks = tasks;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectImport" /> class.
        /// </summary>
        public ProjectImport()
        {
        }
    }
}