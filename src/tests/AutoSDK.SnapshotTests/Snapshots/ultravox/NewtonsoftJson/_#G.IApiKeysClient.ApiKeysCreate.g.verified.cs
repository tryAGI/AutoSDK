//HintName: G.IApiKeysClient.ApiKeysCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Creates a new API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKeyCreate> ApiKeysCreateAsync(
            global::G.APIKeyCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new API key.
        /// </summary>
        /// <param name="name">
        /// A free-form name for the API key. Need not be unique. 50 characters max.
        /// </param>
        /// <param name="expiryDate">
        /// Once API key expires, clients cannot use it anymore.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKeyCreate> ApiKeysCreateAsync(
            string name,
            global::System.DateTime? expiryDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}