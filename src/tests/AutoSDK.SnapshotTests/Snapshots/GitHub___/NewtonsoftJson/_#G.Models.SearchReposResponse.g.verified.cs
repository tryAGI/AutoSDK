//HintName: G.Models.SearchReposResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchReposResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_results", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IncompleteResults { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RepoSearchResultItem> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchReposResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="incompleteResults"></param>
        /// <param name="items"></param>
        public SearchReposResponse(
            int totalCount,
            bool incompleteResults,
            global::System.Collections.Generic.IList<global::G.RepoSearchResultItem> items)
        {
            this.TotalCount = totalCount;
            this.IncompleteResults = incompleteResults;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchReposResponse" /> class.
        /// </summary>
        public SearchReposResponse()
        {
        }
    }
}