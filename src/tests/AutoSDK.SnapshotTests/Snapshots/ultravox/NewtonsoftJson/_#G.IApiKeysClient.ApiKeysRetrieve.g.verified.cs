//HintName: G.IApiKeysClient.ApiKeysRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Gets an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKey> ApiKeysRetrieveAsync(
            string apiKeyPrefix,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}