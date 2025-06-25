//HintName: G.Models.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost
    {
        /// <summary>
        /// The Target language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost" /> class.
        /// </summary>
        /// <param name="language">
        /// The Target language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost(
            string? language)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost" /> class.
        /// </summary>
        public BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost()
        {
        }
    }
}