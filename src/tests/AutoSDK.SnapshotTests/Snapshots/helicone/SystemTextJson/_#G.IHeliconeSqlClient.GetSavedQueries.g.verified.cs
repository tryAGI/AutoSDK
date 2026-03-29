//HintName: G.IHeliconeSqlClient.GetSavedQueries.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// List saved queries<br/>
        /// Get all saved queries for the organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultArrayHqlSavedQueryString> GetSavedQueriesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}