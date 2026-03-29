//HintName: G.ILogsClient.CreateLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Insert New logs<br/>
        /// Submit one or more log entries
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateLogsAsync(

            global::G.OneOf<global::G.CustomLog, global::System.Collections.Generic.IList<global::G.CustomLog>> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert New logs<br/>
        /// Submit one or more log entries
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateLogsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}