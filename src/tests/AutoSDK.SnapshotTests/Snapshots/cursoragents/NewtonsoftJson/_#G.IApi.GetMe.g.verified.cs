//HintName: G.IApi.GetMe.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// API key info<br/>
        /// Retrieve information about the API key being used for authentication
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetMeResponse> GetMeAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}