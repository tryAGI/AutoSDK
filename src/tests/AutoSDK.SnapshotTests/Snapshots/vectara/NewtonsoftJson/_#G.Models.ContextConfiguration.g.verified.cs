//HintName: G.Models.ContextConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration on the presentation of each document part in the result set.
    /// </summary>
    public sealed partial class ContextConfiguration
    {
        /// <summary>
        /// The number of characters before the matching document part that are shown.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_before` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// so as to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_before")]
        public int? CharactersBefore { get; set; } = 0;

        /// <summary>
        /// The number of characters after the matching document part that are shown. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_after` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// so as to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters_after")]
        public int? CharactersAfter { get; set; } = 0;

        /// <summary>
        /// The number of sentences before the matching document part that are shown.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_before")]
        public int? SentencesBefore { get; set; } = 0;

        /// <summary>
        /// The number of sentences after the matching document part that are shown. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_after")]
        public int? SentencesAfter { get; set; } = 0;

        /// <summary>
        /// The tag that wraps the document part at the start. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_tag")]
        public string? StartTag { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the end. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;/em&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_tag")]
        public string? EndTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}