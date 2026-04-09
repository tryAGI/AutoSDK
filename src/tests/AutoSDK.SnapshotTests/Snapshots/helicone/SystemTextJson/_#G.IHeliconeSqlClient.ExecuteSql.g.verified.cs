//HintName: G.IHeliconeSqlClient.ExecuteSql.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Execute SQL query<br/>
        /// Execute a SQL query against ClickHouse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExecuteSqlResponseString> ExecuteSqlAsync(

            global::G.ExecuteSqlRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute SQL query<br/>
        /// Execute a SQL query against ClickHouse
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExecuteSqlResponseString> ExecuteSqlAsync(
            string sql,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}