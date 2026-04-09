//HintName: G.IMetaClient.MetaGetZen.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get the Zen of GitHub<br/>
        /// Get a random sentence from the Zen of GitHub
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetaGetZenAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}