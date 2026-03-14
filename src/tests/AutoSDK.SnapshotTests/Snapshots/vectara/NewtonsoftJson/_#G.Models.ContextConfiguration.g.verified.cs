//HintName: G.Models.ContextConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration on the presentation of each document part in the result set. You can only use characters_before/after or sentences_before/after, but not both. If you specify both in the query, sentences_before/after takes precedence<br/>
    /// Example: {"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"}
    /// </summary>
    public sealed partial class ContextConfiguration
    {
        /// <summary>
        /// The number of characters that are shown before the matching document part. This is useful to show the context of the document part in the wider document. Ignored if `sentences_before` is set. Vectara will capture the full sentence that contains the captured characters, to not lose the meaning caused by a truncated word or sentence.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_before")]
        public int? CharactersBefore { get; set; }

        /// <summary>
        /// The number of characters that are shown after the matching document part. This is useful to show the context of the document part in the wider document. Ignored if `sentences_after` is set. Vectara will capture the full sentence that contains the captured characters, to not lose the meaning caused by a truncated word or sentence.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_after")]
        public int? CharactersAfter { get; set; }

        /// <summary>
        /// The number of sentences that are shown before the matching document part. This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("sentences_before")]
        public int? SentencesBefore { get; set; }

        /// <summary>
        /// The number of sentences that are shown after the matching document part. This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("sentences_after")]
        public int? SentencesAfter { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the start. This is often used to provide a start HTML/XML tag or some other delimiter you can use in an application to understand where to provide highlighting in your UI and understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </summary>
        /// <example>&lt;em&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("start_tag")]
        public string? StartTag { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the end. This is often used to provide a start HTML/XML tag or some other delimiter you can use in an application to understand where to provide highlighting in your UI and understand where the document part ends and the context after begins.<br/>
        /// Example: &lt;/em&gt;
        /// </summary>
        /// <example>&lt;/em&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("end_tag")]
        public string? EndTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        /// <param name="charactersBefore">
        /// The number of characters that are shown before the matching document part. This is useful to show the context of the document part in the wider document. Ignored if `sentences_before` is set. Vectara will capture the full sentence that contains the captured characters, to not lose the meaning caused by a truncated word or sentence.
        /// </param>
        /// <param name="charactersAfter">
        /// The number of characters that are shown after the matching document part. This is useful to show the context of the document part in the wider document. Ignored if `sentences_after` is set. Vectara will capture the full sentence that contains the captured characters, to not lose the meaning caused by a truncated word or sentence.
        /// </param>
        /// <param name="sentencesBefore">
        /// The number of sentences that are shown before the matching document part. This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="sentencesAfter">
        /// The number of sentences that are shown after the matching document part. This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="startTag">
        /// The tag that wraps the document part at the start. This is often used to provide a start HTML/XML tag or some other delimiter you can use in an application to understand where to provide highlighting in your UI and understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </param>
        /// <param name="endTag">
        /// The tag that wraps the document part at the end. This is often used to provide a start HTML/XML tag or some other delimiter you can use in an application to understand where to provide highlighting in your UI and understand where the document part ends and the context after begins.<br/>
        /// Example: &lt;/em&gt;
        /// </param>
        public ContextConfiguration(
            int? charactersBefore,
            int? charactersAfter,
            int? sentencesBefore,
            int? sentencesAfter,
            string? startTag,
            string? endTag)
        {
            this.CharactersBefore = charactersBefore;
            this.CharactersAfter = charactersAfter;
            this.SentencesBefore = sentencesBefore;
            this.SentencesAfter = sentencesAfter;
            this.StartTag = startTag;
            this.EndTag = endTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        public ContextConfiguration()
        {
        }
    }
}