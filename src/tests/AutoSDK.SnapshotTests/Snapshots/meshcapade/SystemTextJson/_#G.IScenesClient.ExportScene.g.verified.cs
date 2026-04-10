//HintName: G.IScenesClient.ExportScene.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Export/download scene
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> ExportSceneAsync(
            global::System.Guid assetID,

            global::G.ExportRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export/download scene
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="format"></param>
        /// <param name="pose"></param>
        /// <param name="compatibilityMode"></param>
        /// <param name="animation"></param>
        /// <param name="filename"></param>
        /// <param name="avatarSceneIndex"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> ExportSceneAsync(
            global::System.Guid assetID,
            global::G.ExportFormat format,
            global::G.ExportPose? pose = default,
            global::G.CompatibilityMode? compatibilityMode = default,
            string? animation = default,
            string? filename = default,
            int? avatarSceneIndex = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}