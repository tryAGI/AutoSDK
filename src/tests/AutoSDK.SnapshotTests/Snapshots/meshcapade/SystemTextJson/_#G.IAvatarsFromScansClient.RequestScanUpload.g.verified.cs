//HintName: G.IAvatarsFromScansClient.RequestScanUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromScansClient
    {
        /// <summary>
        /// Request mesh upload URL for AFS avatar
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> RequestScanUploadAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}