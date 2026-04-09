//HintName: G.IAvatarsFromVideoClient.RequestVideoUploadForAvatar.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromVideoClient
    {
        /// <summary>
        /// Request video upload URL for AFV avatar
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> RequestVideoUploadForAvatarAsync(
            global::System.Guid assetID,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}