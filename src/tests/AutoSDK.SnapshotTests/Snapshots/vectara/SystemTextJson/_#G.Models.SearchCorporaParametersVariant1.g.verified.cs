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

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorporaParametersVariant1" /> class.
        /// </summary>
        /// <param name="corpora">
        /// The corpora that you want to search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCorporaParametersVariant1(
            global::System.Collections.Generic.IList<global::G.KeyedSearchCorpus>? corpora)
        {
            this.Corpora = corpora;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCorporaParametersVariant1" /> class.
        /// </summary>
        public SearchCorporaParametersVariant1()
        {
        }
    }
}