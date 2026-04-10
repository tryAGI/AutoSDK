//HintName: G.IMetaClient.MetaGetOctocat.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get Octocat<br/>
        /// Get the octocat as ASCII art
        /// </summary>
        /// <param name="s"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetaGetOctocatAsync(
            string? s = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}