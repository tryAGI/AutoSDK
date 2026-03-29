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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Direct answer text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Snippet text from the answer source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Highlighted words in the snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippetHighlighted")]
        public global::System.Collections.Generic.IList<string>? SnippetHighlighted { get; set; }

        /// <summary>
        /// Source URL for the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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