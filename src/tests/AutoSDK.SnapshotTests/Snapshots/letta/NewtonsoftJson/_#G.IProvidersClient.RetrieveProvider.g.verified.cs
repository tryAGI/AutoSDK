//HintName: G.IProvidersClient.RetrieveProvider.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Retrieve Provider<br/>
        /// Get a provider by ID.
        /// </summary>
        /// <param name="providerId">
        /// The ID of the provider in the format 'provider-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Provider> RetrieveProviderAsync(
            string providerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}