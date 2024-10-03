//HintName: G.Models.C11yWordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of available words and contexts.
    /// </summary>
    public sealed partial class C11yWordsResponse
    {
        /// <summary>
        /// Weighted results for all words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concatenatedWord")]
        public global::G.C11yWordsResponseConcatenatedWord? ConcatenatedWord { get; set; }

        /// <summary>
        /// Weighted results for per individual word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("individualWords")]
        public global::System.Collections.Generic.IList<global::G.C11yWordsResponseIndividualWord>? IndividualWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}