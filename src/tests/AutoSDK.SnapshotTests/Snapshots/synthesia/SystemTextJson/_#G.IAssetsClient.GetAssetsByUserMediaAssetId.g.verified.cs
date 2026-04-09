//HintName: G.IAssetsClient.GetAssetsByUserMediaAssetId.g.cs
#nullable enable

namespace G
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get user media asset<br/>
        /// Retrieves a user uploaded media asset by its ID. Returns the asset's status, title, content type, and metadata including detected language if available. Currently only supports user-uploaded assets in the dubbing configuration.
        /// </summary>
        /// <param name="userMediaAssetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPublicApiUserUploadedAssetResponse> GetAssetsByUserMediaAssetIdAsync(
            global::System.Guid userMediaAssetId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}