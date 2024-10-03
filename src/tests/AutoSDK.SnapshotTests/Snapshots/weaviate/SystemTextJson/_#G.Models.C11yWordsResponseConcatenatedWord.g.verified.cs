//HintName: G.Models.C11yWordsResponseConcatenatedWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Weighted results for all words
    /// </summary>
    public sealed partial class C11yWordsResponseConcatenatedWord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concatenatedWord")]
        public string? ConcatenatedWord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("singleWords")]
        public global::System.Collections.Generic.IList<string>? SingleWords { get; set; }

        /// <summary>
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concatenatedVector")]
        public global::System.Collections.Generic.IList<float>? ConcatenatedVector { get; set; }

        /// <summary>
        /// C11y function to show the nearest neighbors to a word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concatenatedNearestNeighbors")]
        public global::System.Collections.Generic.IList<global::G.C11yNearestNeighbor>? ConcatenatedNearestNeighbors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}