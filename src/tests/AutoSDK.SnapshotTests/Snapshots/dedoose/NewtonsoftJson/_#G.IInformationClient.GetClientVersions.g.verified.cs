//HintName: G.IInformationClient.GetClientVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IInformationClient
    {
        /// <summary>
        /// Get Client Versions<br/>
        /// Returns a dictionary of client versions from an XML source.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> GetClientVersionsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}