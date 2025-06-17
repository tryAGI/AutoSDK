//HintName: G.Models.BodyCreateChapterV1StudioProjectsProjectIdChaptersPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateChapterV1StudioProjectsProjectIdChaptersPost
    {
        /// <summary>
        /// The name of the chapter, used for identification only.<br/>
        /// Example: Chapter 1
        /// </summary>
        /// <example>Chapter 1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </summary>
        /// <example>https://blog.elevenlabs.io/the_first_ai_that_can_laugh/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateChapterV1StudioProjectsProjectIdChaptersPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the chapter, used for identification only.<br/>
        /// Example: Chapter 1
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' and 'from_content' must be null. If neither 'from_url', 'from_document', 'from_content' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateChapterV1StudioProjectsProjectIdChaptersPost(
            string name,
            string? fromUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromUrl = fromUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateChapterV1StudioProjectsProjectIdChaptersPost" /> class.
        /// </summary>
        public BodyCreateChapterV1StudioProjectsProjectIdChaptersPost()
        {
        }
    }
}