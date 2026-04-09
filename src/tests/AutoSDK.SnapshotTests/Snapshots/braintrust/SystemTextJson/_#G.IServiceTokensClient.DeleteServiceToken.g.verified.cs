//HintName: G.IServiceTokensClient.DeleteServiceToken.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceTokensClient
    {
        /// <summary>
        /// Delete single service_token<br/>
        /// Delete a single service_token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceToken> DeleteServiceTokenAsync(

            global::G.DeleteServiceToken request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete single service_token<br/>
        /// Delete a single service_token
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the service token.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceToken> DeleteServiceTokenAsync(
            global::System.Guid id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}