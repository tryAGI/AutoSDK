//HintName: G.IApi.GetLogsLogsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Recent Logs<br/>
        /// Get recent application logs for debugging
        /// </summary>
        /// <param name="limit">
        /// Maximum number of log entries to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// Filter by log level (DEBUG, INFO, WARNING, ERROR, CRITICAL)
        /// </param>
        /// <param name="since">
        /// Return logs since this ISO timestamp
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLogsLogsGetAsync(
            int? limit = default,
            string? level = default,
            string? since = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}