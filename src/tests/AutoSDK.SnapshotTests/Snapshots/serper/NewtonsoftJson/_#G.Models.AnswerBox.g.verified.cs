//HintName: G.Models.AnswerBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Featured answer box data, if available.
    /// </summary>
    public sealed partial class AnswerBox
    {
        /// <summary>
        /// Title of the answer box.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Direct answer text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Snippet text from the answer source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Highlighted words in the snippet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippetHighlighted")]
        public global::System.Collections.Generic.IList<string>? SnippetHighlighted { get; set; }

        /// <summary>
        /// Source URL for the answer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerBox" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the answer box.
        /// </param>
        /// <param name="answer">
        /// Direct answer text.
        /// </param>
        /// <param name="snippet">
        /// Snippet text from the answer source.
        /// </param>
        /// <param name="snippetHighlighted">
        /// Highlighted words in the snippet.
        /// </param>
        /// <param name="link">
        /// Source URL for the answer.
        /// </param>
        public AnswerBox(
            string? title,
            string? answer,
            string? snippet,
            global::System.Collections.Generic.IList<string>? snippetHighlighted,
            string? link)
        {
            this.Title = title;
            this.Answer = answer;
            this.Snippet = snippet;
            this.SnippetHighlighted = snippetHighlighted;
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerBox" /> class.
        /// </summary>
        public AnswerBox()
        {
        }
    }
}