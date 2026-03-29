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
        [global::Newtonsoft.Json.JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// Answer snippet for the question.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Title of the source page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the source page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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