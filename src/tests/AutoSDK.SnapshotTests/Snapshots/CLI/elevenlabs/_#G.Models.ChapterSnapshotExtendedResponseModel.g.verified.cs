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
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_snapshot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterSnapshotId { get; set; }

        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The ID of the chapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterId { get; set; }

        /// <summary>
        /// The creation date of the chapter snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// The name of the chapter snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_alignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CharacterAlignmentModel> CharacterAlignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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