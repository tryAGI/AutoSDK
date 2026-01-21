//HintName: G.Models.BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch
    {
        /// <summary>
        /// The name of the chapter, used for identification only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The chapter content to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ChapterContentInputModel? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the chapter, used for identification only.
        /// </param>
        /// <param name="content">
        /// The chapter content to use.
        /// </param>
        public BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch(
            string? name,
            global::G.ChapterContentInputModel? content)
        {
            this.Name = name;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch" /> class.
        /// </summary>
        public BodyEditChapterV1ProjectsProjectIdChaptersChapterIdPatch()
        {
        }
    }
}