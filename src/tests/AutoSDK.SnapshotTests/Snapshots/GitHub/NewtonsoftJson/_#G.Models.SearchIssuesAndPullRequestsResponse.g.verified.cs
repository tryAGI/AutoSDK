//HintName: G.Models.SearchIssuesAndPullRequestsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchIssuesAndPullRequestsResponse
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
        public global::System.Collections.Generic.IList<global::G.IssueSearchResultItem> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIssuesAndPullRequestsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="incompleteResults"></param>
        /// <param name="items"></param>
        public SearchIssuesAndPullRequestsResponse(
            int totalCount,
            bool incompleteResults,
            global::System.Collections.Generic.IList<global::G.IssueSearchResultItem> items)
        {
            this.TotalCount = totalCount;
            this.IncompleteResults = incompleteResults;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIssuesAndPullRequestsResponse" /> class.
        /// </summary>
        public SearchIssuesAndPullRequestsResponse()
        {
        }
    }
}