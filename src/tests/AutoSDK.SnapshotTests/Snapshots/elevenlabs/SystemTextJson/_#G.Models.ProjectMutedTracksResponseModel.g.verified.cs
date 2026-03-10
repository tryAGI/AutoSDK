//HintName: G.Models.ProjectMutedTracksResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"chapter_ids":["aw1NgEzBg83R7vgmiJt6"]}
    /// </summary>
    public sealed partial class ProjectMutedTracksResponseModel
    {
        /// <summary>
        /// List of chapter IDs that have muted tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChapterIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMutedTracksResponseModel" /> class.
        /// </summary>
        /// <param name="chapterIds">
        /// List of chapter IDs that have muted tracks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMutedTracksResponseModel(
            global::System.Collections.Generic.IList<string> chapterIds)
        {
            this.ChapterIds = chapterIds ?? throw new global::System.ArgumentNullException(nameof(chapterIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMutedTracksResponseModel" /> class.
        /// </summary>
        public ProjectMutedTracksResponseModel()
        {
        }
    }
}