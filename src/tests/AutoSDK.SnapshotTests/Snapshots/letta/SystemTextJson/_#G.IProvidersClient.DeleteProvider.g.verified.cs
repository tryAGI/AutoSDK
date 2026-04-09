//HintName: G.IProvidersClient.DeleteProvider.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Delete Provider<br/>
        /// Delete an existing custom provider.
        /// </summary>
        /// <param name="providerId">
        /// The ID of the provider in the format 'provider-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteProviderAsync(
            string providerId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}