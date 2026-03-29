//HintName: G.Models.PeopleAlsoAskItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single People Also Ask question.
    /// </summary>
    public sealed partial class PeopleAlsoAskItem
    {
        /// <summary>
        /// The question text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        /// Answer snippet for the question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Title of the source page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the source page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleAlsoAskItem" /> class.
        /// </summary>
        /// <param name="question">
        /// The question text.
        /// </param>
        /// <param name="snippet">
        /// Answer snippet for the question.
        /// </param>
        /// <param name="title">
        /// Title of the source page.
        /// </param>
        /// <param name="link">
        /// URL of the source page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeopleAlsoAskItem(
            string? question,
            string? snippet,
            string? title,
            string? link)
        {
            this.Question = question;
            this.Snippet = snippet;
            this.Title = title;
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleAlsoAskItem" /> class.
        /// </summary>
        public PeopleAlsoAskItem()
        {
        }
    }
}