//HintName: G.IAuthConfigsClient.PatchAuthConfigsByNanoid.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Update an authentication configuration<br/>
        /// Modifies an existing authentication configuration with new credentials or other settings. Only specified fields will be updated.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchAuthConfigsByNanoidAsync(
            string nanoid,

            global::G.OneOf<global::G.PatchAuthConfigsByNanoidRequestVariant1, global::G.PatchAuthConfigsByNanoidRequestVariant2> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an authentication configuration<br/>
        /// Modifies an existing authentication configuration with new credentials or other settings. Only specified fields will be updated.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchAuthConfigsByNanoidAsync(
            string nanoid,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}