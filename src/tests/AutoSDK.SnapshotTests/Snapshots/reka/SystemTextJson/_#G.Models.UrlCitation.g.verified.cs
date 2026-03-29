//HintName: G.Models.UrlCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// URL citation details with character-level positioning in the response content.
    /// </summary>
    public sealed partial class UrlCitation
    {
        /// <summary>
        /// The web resource URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Title of the cited resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Character position in content where the citation starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// Character position in content where the citation ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        /// <param name="url">
        /// The web resource URL.
        /// </param>
        /// <param name="title">
        /// Title of the cited resource.
        /// </param>
        /// <param name="startIndex">
        /// Character position in content where the citation starts.
        /// </param>
        /// <param name="endIndex">
        /// Character position in content where the citation ends.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlCitation(
            string url,
            string title,
            int startIndex,
            int endIndex)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlCitation" /> class.
        /// </summary>
        public UrlCitation()
        {
        }
    }
}