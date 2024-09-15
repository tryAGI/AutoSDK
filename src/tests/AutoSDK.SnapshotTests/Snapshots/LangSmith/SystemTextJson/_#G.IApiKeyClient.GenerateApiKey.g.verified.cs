//HintName: G.IApiKeyClient.GenerateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Generate Api Key<br/>
        /// Generate an api key for the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKeyCreateResponse> GenerateApiKeyAsync(
            global::G.AllOf<global::G.APIKeyCreateRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Api Key<br/>
        /// Generate an api key for the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKeyCreateResponse> GenerateApiKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}