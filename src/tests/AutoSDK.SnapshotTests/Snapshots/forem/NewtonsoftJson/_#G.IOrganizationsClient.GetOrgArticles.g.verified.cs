//HintName: G.IOrganizationsClient.GetOrgArticles.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Organization's Articles<br/>
        /// This endpoint allows the client to retrieve a list of Articles belonging to the organization<br/>
        /// It supports pagination, each page will contain `30` users by default.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ArticleIndex>> GetOrgArticlesAsync(
            string username,
            int? page = default,
            int? perPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}