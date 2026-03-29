//HintName: G.ISandboxesClient.CreateSandboxesBySandboxIDTimeout.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Set the timeout for the sandbox. The sandbox will expire x seconds from the time of the request. Calling this method multiple times overwrites the TTL, each time using the current timestamp as the starting point to measure the timeout duration.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDTimeoutAsync(
            string sandboxID,

            global::G.CreateSandboxesTimeoutRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the timeout for the sandbox. The sandbox will expire x seconds from the time of the request. Calling this method multiple times overwrites the TTL, each time using the current timestamp as the starting point to measure the timeout duration.
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSandboxesBySandboxIDTimeoutAsync(
            string sandboxID,
            int timeout,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}