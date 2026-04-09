//HintName: G.IFilesClient.PostFilesUploadRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Create presigned URL for request file upload to S3<br/>
        /// Generates a presigned URL for uploading a file to S3. This endpoint handles deduplication by checking if a file with the same MD5 hash already exists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostFilesUploadRequestResponse> PostFilesUploadRequestAsync(

            global::G.PostFilesUploadRequestRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create presigned URL for request file upload to S3<br/>
        /// Generates a presigned URL for uploading a file to S3. This endpoint handles deduplication by checking if a file with the same MD5 hash already exists.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Slug of the app where this file belongs to. Example: "gmail", "slack", "github"
        /// </param>
        /// <param name="toolSlug">
        /// Slug of the action where this file belongs to. Example: "GMAIL_SEND_EMAIL", "SLACK_UPLOAD_FILE"
        /// </param>
        /// <param name="filename">
        /// Name of the original file. Example: "quarterly_report.pdf"
        /// </param>
        /// <param name="mimetype">
        /// Mime type of the original file. Example: "application/pdf", "image/png"
        /// </param>
        /// <param name="md5">
        /// MD5 hash of the file for deduplication and integrity verification. Example: "a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6"
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostFilesUploadRequestResponse> PostFilesUploadRequestAsync(
            string toolkitSlug,
            string toolSlug,
            string filename,
            string mimetype,
            string md5,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}