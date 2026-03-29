//HintName: G.IHeliconeSqlClient.DeleteSavedQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Delete saved query<br/>
        /// Delete a saved query by ID
        /// </summary>
        /// <param name="queryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultVoidString> DeleteSavedQueryAsync(
            string queryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}