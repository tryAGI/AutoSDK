//HintName: G.IApiKeysClient.GetApiKeyId.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Get api_key<br/>
        /// Get an api_key object by its id
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> GetApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}