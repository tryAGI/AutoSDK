//HintName: G.ITelemetryClient.RetrieveProviderTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITelemetryClient
    {
        /// <summary>
        /// Retrieve Provider Trace<br/>
        /// **DEPRECATED**: Use `GET /steps/{step_id}/trace` instead.<br/>
        /// Retrieve provider trace by step ID.
        /// </summary>
        /// <param name="stepId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ProviderTrace> RetrieveProviderTraceAsync(
            string stepId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}