//HintName: G.ISearchClient.SearchLabels.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search labels<br/>
        /// Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:<br/>
        /// `q=bug+defect+enhancement&amp;repository_id=64778136`<br/>
        /// The labels that best match the query appear first in the search results.
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchLabelsResponse> SearchLabelsAsync(
            int repositoryId,
            string q,
            global::G.SearchLabelsSort? sort = default,
            global::G.SearchLabelsOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}