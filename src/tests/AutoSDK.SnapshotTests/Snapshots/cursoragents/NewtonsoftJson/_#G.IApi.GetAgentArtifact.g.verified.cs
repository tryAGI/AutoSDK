//HintName: G.IApi.GetAgentArtifact.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Download an artifact<br/>
        /// Retrieve a temporary 15-minute presigned S3 URL for a specific artifact from an agent created within the last 6 months. The response includes both the URL and its expiration time.
        /// </summary>
        /// <param name="id">
        /// Example: bc-00000000-0000-0000-0000-000000000001
        /// </param>
        /// <param name="path">
        /// Example: /opt/cursor/artifacts/screenshot.png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetArtifactResponse> GetAgentArtifactAsync(
            string id,
            string path,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}