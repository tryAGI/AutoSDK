//HintName: G.IImagesClient.UploadAnImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Upload image<br/>
        /// Upload an image to a temporary storage before creating an animation.<br/>
        /// The image is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: image/jpeg,image/png<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadAnImageResponse> UploadAnImageAsync(

            global::G.UploadAnImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload image<br/>
        /// Upload an image to a temporary storage before creating an animation.<br/>
        /// The image is uploaded using multipart/form-data. the filename directive is optional and if provided should contain up to 50 valid characters long.<br/>
        /// Valid characters: a-z A-Z 0-9 . _ -<br/>
        /// Supported mime types: image/jpeg,image/png<br/>
        /// Storage duration: 24-48H
        /// </summary>
        /// <param name="image">
        /// The binary data of the image
        /// </param>
        /// <param name="imagename">
        /// The binary data of the image
        /// </param>
        /// <param name="detectFaces"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="resultUrl">
        /// A URL to upload the image to. If provided, the image will be uploaded to this URL instead of the default bucket. Should be an https presigned URL. S3 presigned urls should have the putObject permission with content type matching the uploaded image.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadAnImageResponse> UploadAnImageAsync(
            byte[]? image = default,
            string? imagename = default,
            string? detectFaces = default,
            string? metadata = default,
            string? sourceUrl = default,
            string? resultUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}