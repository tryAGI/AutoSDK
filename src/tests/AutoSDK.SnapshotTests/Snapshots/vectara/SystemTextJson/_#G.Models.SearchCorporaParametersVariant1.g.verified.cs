//HintName: G.Models.SearchCorporaParametersVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCorporaParametersVariant1
    {
        /// <summary>
        /// The corpora that you want to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpora")]
        public global::System.Collections.Generic.IList<global::G.KeyedSearchCorpus>? Corpora { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}