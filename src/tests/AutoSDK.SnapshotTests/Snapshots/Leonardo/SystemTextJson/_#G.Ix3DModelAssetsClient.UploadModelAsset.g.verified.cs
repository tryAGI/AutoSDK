//HintName: G.Ix3DModelAssetsClient.UploadModelAsset.g.cs
#nullable enable

namespace G
{
    public partial interface Ix3DModelAssetsClient
    {
        /// <summary>
        /// Upload 3D Model<br/>
        /// This endpoint returns presigned details to upload a 3D model to S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadModelAssetResponse> UploadModelAssetAsync(
            global::G.UploadModelAssetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload 3D Model<br/>
        /// This endpoint returns presigned details to upload a 3D model to S3
        /// </summary>
        /// <param name="modelExtension"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadModelAssetResponse> UploadModelAssetAsync(
            string? modelExtension = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}