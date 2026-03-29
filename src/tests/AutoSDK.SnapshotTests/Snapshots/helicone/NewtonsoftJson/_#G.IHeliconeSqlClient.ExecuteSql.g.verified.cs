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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExecuteSqlResponseString> ExecuteSqlAsync(

            global::G.ExecuteSqlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute SQL query<br/>
        /// Execute a SQL query against ClickHouse
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExecuteSqlResponseString> ExecuteSqlAsync(
            string sql,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}