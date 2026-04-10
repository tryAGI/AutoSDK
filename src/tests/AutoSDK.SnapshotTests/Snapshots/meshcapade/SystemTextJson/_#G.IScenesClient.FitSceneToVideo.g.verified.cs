//HintName: G.IScenesClient.FitSceneToVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,

            global::G.FitToVideoRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start scene fitting to video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="lockFeet"></param>
        /// <param name="modelVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> FitSceneToVideoAsync(
            global::System.Guid assetID,
            bool? lockFeet = default,
            string? modelVersion = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}