//HintName: G.ILogsClient.GetLogsByLogId.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get a specific log
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LogObject> GetLogsByLogIdAsync(
            string logId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}