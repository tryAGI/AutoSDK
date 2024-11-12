//HintName: G.IApiKeyClient.DeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeyClient
    {
        /// <summary>
        /// Delete Api Key<br/>
        /// Delete an api key for the user
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.APIKeyGetResponse> DeleteApiKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}