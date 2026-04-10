//HintName: G.ISandboxesClient.GetSandboxes.g.cs
#nullable enable

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List all running sandboxes
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ListedSandbox>> GetSandboxesAsync(
            string? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}