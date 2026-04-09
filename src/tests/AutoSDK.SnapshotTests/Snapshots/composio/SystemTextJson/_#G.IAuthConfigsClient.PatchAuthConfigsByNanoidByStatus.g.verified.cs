//HintName: G.IAuthConfigsClient.PatchAuthConfigsByNanoidByStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Enable or disable an authentication configuration<br/>
        /// Updates the status of an authentication configuration to either enabled or disabled. Disabled configurations cannot be used for new connections.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="status">
        /// The new status to set for the auth configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchAuthConfigsByNanoidByStatusAsync(
            string nanoid,
            global::G.PatchAuthConfigsByNanoidByStatusStatus status,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}