//HintName: G.IInitImagesClient.UploadInitImage.g.cs
#nullable enable

namespace G
{
    public partial interface IInitImagesClient
    {
        /// <summary>
        /// Upload init image<br/>
        /// This endpoint returns presigned details to upload an init image to S3
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadInitImageResponse> UploadInitImageAsync(
            global::G.UploadInitImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload init image<br/>
        /// This endpoint returns presigned details to upload an init image to S3
        /// </summary>
        /// <param name="extension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadInitImageResponse> UploadInitImageAsync(
            string extension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}