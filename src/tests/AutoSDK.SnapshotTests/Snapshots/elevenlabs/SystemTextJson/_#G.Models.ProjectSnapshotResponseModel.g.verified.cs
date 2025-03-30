//HintName: G.Models.ProjectSnapshotResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSnapshotResponseModel
    {
        /// <summary>
        /// The ID of the project snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_snapshot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectSnapshotId { get; set; }

        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The creation date of the project snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// The name of the project snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// (Deprecated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_upload")]
        public object? AudioUpload { get; set; }

        /// <summary>
        /// (Deprecated)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip_upload")]
        public object? ZipUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotResponseModel" /> class.
        /// </summary>
        /// <param name="projectSnapshotId">
        /// The ID of the project snapshot.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="createdAtUnix">
        /// The creation date of the project snapshot.
        /// </param>
        /// <param name="name">
        /// The name of the project snapshot.
        /// </param>
        /// <param name="audioUpload">
        /// (Deprecated)
        /// </param>
        /// <param name="zipUpload">
        /// (Deprecated)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSnapshotResponseModel(
            string projectSnapshotId,
            string projectId,
            int createdAtUnix,
            string name,
            object? audioUpload,
            object? zipUpload)
        {
            this.ProjectSnapshotId = projectSnapshotId ?? throw new global::System.ArgumentNullException(nameof(projectSnapshotId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CreatedAtUnix = createdAtUnix;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AudioUpload = audioUpload;
            this.ZipUpload = zipUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotResponseModel()
        {
        }
    }
}