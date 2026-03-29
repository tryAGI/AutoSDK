//HintName: G.Models.RelatedSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A related search suggestion.
    /// </summary>
    public sealed partial class RelatedSearch
    {
        /// <summary>
        /// The related search query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// The related search query.
        /// </param>
        public RelatedSearch(
            string? query)
        {
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedSearch" /> class.
        /// </summary>
        public RelatedSearch()
        {
        }
    }
}