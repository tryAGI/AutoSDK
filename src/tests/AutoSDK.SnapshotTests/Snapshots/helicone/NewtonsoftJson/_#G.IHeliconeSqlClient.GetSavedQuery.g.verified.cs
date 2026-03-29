//HintName: G.IHeliconeSqlClient.GetSavedQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Get saved query<br/>
        /// Get a specific saved query by ID
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHqlSavedQueryOrNullString> GetSavedQueryAsync(
            string queryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}