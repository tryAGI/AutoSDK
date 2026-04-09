//HintName: G.IPlaygroundSettingsClient.ListPlaygroundSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// List Playground Settings<br/>
        /// Get all playground settings for this tenant id.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PlaygroundSettingsResponse>> ListPlaygroundSettingsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}