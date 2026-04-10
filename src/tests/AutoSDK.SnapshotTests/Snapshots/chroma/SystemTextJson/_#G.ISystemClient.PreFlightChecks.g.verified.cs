//HintName: G.ISystemClient.PreFlightChecks.g.cs
#nullable enable

namespace G
{
    public partial interface ISystemClient
    {
        /// <summary>
        /// Pre-flight checks<br/>
        /// Returns basic readiness information.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChecklistResponse> PreFlightChecksAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}