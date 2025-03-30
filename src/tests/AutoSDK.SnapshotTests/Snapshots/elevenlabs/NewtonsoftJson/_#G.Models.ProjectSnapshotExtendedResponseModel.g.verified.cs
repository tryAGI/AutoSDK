//HintName: G.Models.ProjectSnapshotExtendedResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSnapshotExtendedResponseModel
    {
        /// <summary>
        /// The ID of the project snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_snapshot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectSnapshotId { get; set; } = default!;

        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The creation date of the project snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// The name of the project snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// (Deprecated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_upload")]
        public object? AudioUpload { get; set; }

        /// <summary>
        /// (Deprecated)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zip_upload")]
        public object? ZipUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_alignments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CharacterAlignmentModel> CharacterAlignments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotExtendedResponseModel" /> class.
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
        /// <param name="characterAlignments"></param>
        public ProjectSnapshotExtendedResponseModel(
            string projectSnapshotId,
            string projectId,
            int createdAtUnix,
            string name,
            global::System.Collections.Generic.IList<global::G.CharacterAlignmentModel> characterAlignments,
            object? audioUpload,
            object? zipUpload)
        {
            this.ProjectSnapshotId = projectSnapshotId ?? throw new global::System.ArgumentNullException(nameof(projectSnapshotId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.CreatedAtUnix = createdAtUnix;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CharacterAlignments = characterAlignments ?? throw new global::System.ArgumentNullException(nameof(characterAlignments));
            this.AudioUpload = audioUpload;
            this.ZipUpload = zipUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSnapshotExtendedResponseModel" /> class.
        /// </summary>
        public ProjectSnapshotExtendedResponseModel()
        {
        }
    }
}