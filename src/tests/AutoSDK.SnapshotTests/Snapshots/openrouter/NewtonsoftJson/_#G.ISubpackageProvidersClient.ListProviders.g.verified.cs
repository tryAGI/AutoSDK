//HintName: G.ISubpackageProvidersClient.ListProviders.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageProvidersClient
    {
        /// <summary>
        /// List all providers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProvidersListProvidersResponse200> ListProvidersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}