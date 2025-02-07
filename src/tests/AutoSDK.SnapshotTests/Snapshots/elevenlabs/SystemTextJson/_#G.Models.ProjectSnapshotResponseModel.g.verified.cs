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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_snapshot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_upload")]
        public global::G.ProjectSnapshotUploadResponseModel? AudioUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip_upload")]
        public global::G.ProjectSnapshotUploadResponseModel? ZipUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotResponseModel" /> class.
        /// </summary>
        /// <param name="projectSnapshotId"></param>
        /// <param name="projectId"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="name"></param>
        /// <param name="audioUpload"></param>
        /// <param name="zipUpload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSnapshotResponseModel(
            string projectSnapshotId,
            string projectId,
            int createdAtUnix,
            string name,
            global::G.ProjectSnapshotUploadResponseModel? audioUpload,
            global::G.ProjectSnapshotUploadResponseModel? zipUpload)
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