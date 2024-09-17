//HintName: G.IReposClient.ReposListPublic.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List public repositories<br/>
        /// Lists all public repositories in the order that they were created.<br/>
        /// Note:<br/>
        /// - For GitHub Enterprise Server, this endpoint will only list repositories available to all users on the enterprise.<br/>
        /// - Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of repositories.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> ReposListPublicAsync(
            int? since = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}