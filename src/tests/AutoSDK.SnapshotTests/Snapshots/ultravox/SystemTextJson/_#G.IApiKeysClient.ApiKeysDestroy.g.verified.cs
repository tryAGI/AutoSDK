//HintName: G.IApiKeysClient.ApiKeysDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Deletes an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiKeysDestroyAsync(
            string apiKeyPrefix,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}