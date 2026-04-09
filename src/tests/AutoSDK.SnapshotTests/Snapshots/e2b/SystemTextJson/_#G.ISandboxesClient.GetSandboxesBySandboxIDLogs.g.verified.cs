//HintName: G.ISandboxesClient.GetSandboxesBySandboxIDLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox logs. Use /v2/sandboxes/{sandboxID}/logs instead.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="start"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.SandboxLogs> GetSandboxesBySandboxIDLogsAsync(
            string sandboxID,
            long? start = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}