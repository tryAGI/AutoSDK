//HintName: G.Models.ChapterSnapshotExtendedResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterSnapshotExtendedResponseModel
    {
        /// <summary>
        /// The ID of the chapter snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_snapshot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterSnapshotId { get; set; } = default!;

        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The ID of the chapter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterId { get; set; } = default!;

        /// <summary>
        /// The creation date of the chapter snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// The name of the chapter snapshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ChapterSnapshotExtendedResponseModel" /> class.
        /// </summary>
        /// <param name="chapterSnapshotId">
        /// The ID of the chapter snapshot.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project.
        /// </param>
        /// <param name="chapterId">
        /// The ID of the chapter.
        /// </param>
        /// <param name="createdAtUnix">
        /// The creation date of the chapter snapshot.
        /// </param>
        /// <param name="name">
        /// The name of the chapter snapshot.
        /// </param>
        /// <param name="characterAlignments"></param>
        public ChapterSnapshotExtendedResponseModel(
            string chapterSnapshotId,
            string projectId,
            string chapterId,
            int createdAtUnix,
            string name,
            global::System.Collections.Generic.IList<global::G.CharacterAlignmentModel> characterAlignments)
        {
            this.ChapterSnapshotId = chapterSnapshotId ?? throw new global::System.ArgumentNullException(nameof(chapterSnapshotId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.CreatedAtUnix = createdAtUnix;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CharacterAlignments = characterAlignments ?? throw new global::System.ArgumentNullException(nameof(characterAlignments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterSnapshotExtendedResponseModel" /> class.
        /// </summary>
        public ChapterSnapshotExtendedResponseModel()
        {
        }
    }
}