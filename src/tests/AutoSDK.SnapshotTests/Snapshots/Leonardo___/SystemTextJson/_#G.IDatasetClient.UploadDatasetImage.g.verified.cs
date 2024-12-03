//HintName: G.IDatasetClient.UploadDatasetImage.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Upload dataset image<br/>
        /// This endpoint returns presigned details to upload a dataset image to S3
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadDatasetImageResponse> UploadDatasetImageAsync(
            string datasetId,
            global::G.UploadDatasetImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload dataset image<br/>
        /// This endpoint returns presigned details to upload a dataset image to S3
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="extension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadDatasetImageResponse> UploadDatasetImageAsync(
            string datasetId,
            string extension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}