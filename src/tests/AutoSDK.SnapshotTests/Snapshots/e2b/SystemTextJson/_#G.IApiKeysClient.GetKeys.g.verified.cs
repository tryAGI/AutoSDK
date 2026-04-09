//HintName: G.IApiKeysClient.GetKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List all team API keys
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamAPIKey>> GetKeysAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}