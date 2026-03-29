//HintName: G.IApi.SessionsGetLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Session Logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SessionLog>> SessionsGetLogsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}