//HintName: G.IApiKeysClient.DeleteApiKeyId.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete api_key<br/>
        /// Delete an api_key object by its id
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKey> DeleteApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}