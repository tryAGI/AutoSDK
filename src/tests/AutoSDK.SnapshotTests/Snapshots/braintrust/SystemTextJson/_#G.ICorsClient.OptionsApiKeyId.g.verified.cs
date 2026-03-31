//HintName: G.ICorsClient.OptionsApiKeyId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/api_key/{api_key_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="apiKeyId">
        /// ApiKey id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsApiKeyIdAsync(
            global::System.Guid apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}