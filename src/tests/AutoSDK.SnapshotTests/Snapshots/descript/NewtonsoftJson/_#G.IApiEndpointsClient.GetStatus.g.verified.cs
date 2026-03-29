//HintName: G.IApiEndpointsClient.GetStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Check API status<br/>
        /// &gt; **Work in progress** — This endpoint is not yet available and will return an error if called.<br/>
        /// Check API availability and validate authentication token.<br/>
        /// This endpoint can be used to:<br/>
        /// - Verify that your authentication token is valid<br/>
        /// - Check API connectivity without performing any heavy operations<br/>
        /// Returns a success response if the token is valid, or a 401 error if the token is invalid or missing.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetStatusResponse> GetStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}