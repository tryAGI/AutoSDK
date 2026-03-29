//HintName: G.IProvidersClient.CreateProvider.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Create Provider<br/>
        /// Create a new custom provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Provider> CreateProviderAsync(

            global::G.ProviderCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Provider<br/>
        /// Create a new custom provider.
        /// </summary>
        /// <param name="name">
        /// The name of the provider.
        /// </param>
        /// <param name="providerType">
        /// The type of the provider.
        /// </param>
        /// <param name="apiKey">
        /// API key or secret key used for requests to the provider.
        /// </param>
        /// <param name="accessKey">
        /// Access key used for requests to the provider.
        /// </param>
        /// <param name="region">
        /// Region used for requests to the provider.
        /// </param>
        /// <param name="baseUrl">
        /// Base URL used for requests to the provider.
        /// </param>
        /// <param name="apiVersion">
        /// API version used for requests to the provider.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Provider> CreateProviderAsync(
            string name,
            global::G.ProviderType providerType,
            string apiKey,
            string? accessKey = default,
            string? region = default,
            string? baseUrl = default,
            string? apiVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}