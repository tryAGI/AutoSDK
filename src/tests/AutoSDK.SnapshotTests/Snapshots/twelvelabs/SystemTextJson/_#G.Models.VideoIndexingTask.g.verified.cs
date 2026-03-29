//HintName: G.Models.VideoIndexingTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video indexing task that describes the status of the task and the metadata about the video.
    /// </summary>
    public sealed partial class VideoIndexingTask
    {
        /// <summary>
        /// A string representing the unique identifier of the task. It is assigned by the platform when a new task is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string representing the unique identifier of the video associated with the specified video indexing task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the task object was last updated. The platform updates this field every time the video indexing task transitions to a different state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string indicating the status of the video indexing task. See the [Task object](/v1.3/api-reference/upload-content/tasks/the-task-object) page for a list of possible statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A string representing the unique identifier of the index to which the video must be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        public string? IndexId { get; set; }

        /// <summary>
        /// System-generated metadata about the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public global::G.VideoIndexingTaskSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoIndexingTask" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of the task. It is assigned by the platform when a new task is created.
        /// </param>
        /// <param name="videoId">
        /// A string representing the unique identifier of the video associated with the specified video indexing task.
        /// </param>
        /// <param name="createdAt">
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the task was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the task object was last updated. The platform updates this field every time the video indexing task transitions to a different state.
        /// </param>
        /// <param name="status">
        /// A string indicating the status of the video indexing task. See the [Task object](/v1.3/api-reference/upload-content/tasks/the-task-object) page for a list of possible statuses.
        /// </param>
        /// <param name="indexId">
        /// A string representing the unique identifier of the index to which the video must be uploaded.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated metadata about the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoIndexingTask(
            string? id,
            string? videoId,
            string? createdAt,
            string? updatedAt,
            string? status,
            string? indexId,
            global::G.VideoIndexingTaskSystemMetadata? systemMetadata)
        {
            this.Id = id;
            this.VideoId = videoId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status;
            this.IndexId = indexId;
            this.SystemMetadata = systemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoIndexingTask" /> class.
        /// </summary>
        public VideoIndexingTask()
        {
        }
    }
}