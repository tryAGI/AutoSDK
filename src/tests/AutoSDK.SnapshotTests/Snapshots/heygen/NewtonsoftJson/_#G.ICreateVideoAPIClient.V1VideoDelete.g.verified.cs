//HintName: G.ICreateVideoApiClient.V1VideoDelete.g.cs
#nullable enable

namespace G
{
    public partial interface ICreateVideoApiClient
    {
        /// <summary>
        /// v1/video.delete<br/>
        /// v1/video.delete
        /// </summary>
        /// <param name="videoId">
        /// Example: &lt;video_id&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1VideoDeleteAsync(
            string? videoId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}