//HintName: G.Models.ApiProjectsImportCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response format varies by edition. Non-Community editions return `{"import": &lt;import_id&gt;}` for async processing. Community edition returns the detailed response below with task counts.
    /// </summary>
    public sealed partial class ApiProjectsImportCreateResponse
    {
        /// <summary>
        /// Number of annotations added (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_count")]
        public int? AnnotationCount { get; set; }

        /// <summary>
        /// Whether uploaded files can contain lists of tasks, like CSV/TSV files (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("could_be_tasks_list")]
        public bool? CouldBeTasksList { get; set; }

        /// <summary>
        /// The list of found data columns (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_columns")]
        public global::System.Collections.Generic.IList<string>? DataColumns { get; set; }

        /// <summary>
        /// Time in seconds to create (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Database IDs of uploaded files (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload_ids")]
        public global::System.Collections.Generic.IList<int>? FileUploadIds { get; set; }

        /// <summary>
        /// The list of found file formats (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found_formats")]
        public global::System.Collections.Generic.IList<string>? FoundFormats { get; set; }

        /// <summary>
        /// Import ID for async operations (non-Community editions only). Use this ID to poll `/api/projects/{project_id}/imports/{import_id}` for status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public int? Import { get; set; }

        /// <summary>
        /// Number of predictions added (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions_count")]
        public int? PredictionsCount { get; set; }

        /// <summary>
        /// Number of tasks added (Community edition sync import only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_count")]
        public int? TaskCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsImportCreateResponse" /> class.
        /// </summary>
        /// <param name="annotationCount">
        /// Number of annotations added (Community edition sync import only)
        /// </param>
        /// <param name="couldBeTasksList">
        /// Whether uploaded files can contain lists of tasks, like CSV/TSV files (Community edition sync import only)
        /// </param>
        /// <param name="dataColumns">
        /// The list of found data columns (Community edition sync import only)
        /// </param>
        /// <param name="duration">
        /// Time in seconds to create (Community edition sync import only)
        /// </param>
        /// <param name="fileUploadIds">
        /// Database IDs of uploaded files (Community edition sync import only)
        /// </param>
        /// <param name="foundFormats">
        /// The list of found file formats (Community edition sync import only)
        /// </param>
        /// <param name="import">
        /// Import ID for async operations (non-Community editions only). Use this ID to poll `/api/projects/{project_id}/imports/{import_id}` for status.
        /// </param>
        /// <param name="predictionsCount">
        /// Number of predictions added (Community edition sync import only)
        /// </param>
        /// <param name="taskCount">
        /// Number of tasks added (Community edition sync import only)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsImportCreateResponse(
            int? annotationCount,
            bool? couldBeTasksList,
            global::System.Collections.Generic.IList<string>? dataColumns,
            double? duration,
            global::System.Collections.Generic.IList<int>? fileUploadIds,
            global::System.Collections.Generic.IList<string>? foundFormats,
            int? import,
            int? predictionsCount,
            int? taskCount)
        {
            this.AnnotationCount = annotationCount;
            this.CouldBeTasksList = couldBeTasksList;
            this.DataColumns = dataColumns;
            this.Duration = duration;
            this.FileUploadIds = fileUploadIds;
            this.FoundFormats = foundFormats;
            this.Import = import;
            this.PredictionsCount = predictionsCount;
            this.TaskCount = taskCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsImportCreateResponse" /> class.
        /// </summary>
        public ApiProjectsImportCreateResponse()
        {
        }
    }
}