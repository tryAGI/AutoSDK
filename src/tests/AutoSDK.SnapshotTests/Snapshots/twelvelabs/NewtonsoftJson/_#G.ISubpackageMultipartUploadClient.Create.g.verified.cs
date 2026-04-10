//HintName: G.ISubpackageMultipartUploadClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// Create a multipart upload session<br/>
        /// This method creates a multipart upload session.<br/>
        /// **Supported content**: Video and audio<br/>
        /// **File size**: 4GB maximum.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetUploadResponse> CreateAsync(
            string xApiKey,

            global::G.CreateAssetUploadRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a multipart upload session<br/>
        /// This method creates a multipart upload session.<br/>
        /// **Supported content**: Video and audio<br/>
        /// **File size**: 4GB maximum.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="filename">
        /// The original file name of the asset.
        /// </param>
        /// <param name="type">
        /// The type of asset you want to upload.
        /// </param>
        /// <param name="totalSize">
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetUploadResponse> CreateAsync(
            string xApiKey,
            string filename,
            long totalSize,
            global::G.CreateAssetUploadRequestType type = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}