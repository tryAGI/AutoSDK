//HintName: G.ISandboxesClient.GetSandboxesBySandboxIDLogs2.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox logs
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="direction">
        /// Direction of the logs that should be returned
        /// </param>
        /// <param name="level">
        /// State of the sandbox
        /// </param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SandboxLogsV2Response> GetSandboxesBySandboxIDLogs2Async(
            string sandboxID,
            long? cursor = default,
            int? limit = default,
            global::G.LogsDirection? direction = default,
            global::G.LogLevel? level = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}