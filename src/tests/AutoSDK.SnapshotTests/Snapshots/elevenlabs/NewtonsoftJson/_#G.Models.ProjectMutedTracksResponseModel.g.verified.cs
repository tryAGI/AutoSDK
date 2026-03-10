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
        [global::Newtonsoft.Json.JsonProperty("chapter_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ChapterIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMutedTracksResponseModel" /> class.
        /// </summary>
        /// <param name="chapterIds">
        /// List of chapter IDs that have muted tracks.
        /// </param>
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