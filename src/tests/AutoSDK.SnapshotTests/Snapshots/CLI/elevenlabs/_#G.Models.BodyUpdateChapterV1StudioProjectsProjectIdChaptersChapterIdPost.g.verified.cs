//HintName: G.Models.BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost
    {
        /// <summary>
        /// The name of the chapter, used for identification only.<br/>
        /// Example: Chapter 1
        /// </summary>
        /// <example>Chapter 1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::G.ChapterContentInputModel? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the chapter, used for identification only.<br/>
        /// Example: Chapter 1
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost(
            string? name,
            global::G.ChapterContentInputModel? content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost" /> class.
        /// </summary>
        public BodyUpdateChapterV1StudioProjectsProjectIdChaptersChapterIdPost()
        {
        }
    }
}