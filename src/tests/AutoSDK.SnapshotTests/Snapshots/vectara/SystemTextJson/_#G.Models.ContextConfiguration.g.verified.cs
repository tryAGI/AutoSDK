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
        /// The number of characters that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_before` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_before")]
        public int? CharactersBefore { get; set; } = 0;

        /// <summary>
        /// The number of characters that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_after` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_after")]
        public int? CharactersAfter { get; set; } = 0;

        /// <summary>
        /// The number of sentences that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_before")]
        public int? SentencesBefore { get; set; } = 0;

        /// <summary>
        /// The number of sentences that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_after")]
        public int? SentencesAfter { get; set; } = 0;

        /// <summary>
        /// The tag that wraps the document part at the start. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_tag")]
        public string? StartTag { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the end. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;/em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_tag")]
        public string? EndTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}