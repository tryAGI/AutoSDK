//HintName: G.ISubpackageMultipartUploadClient.ListIncompleteUploads.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// List incomplete uploads<br/>
        /// This method returns a list of all incomplete multipart upload sessions in your account.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListIncompleteUploadsResponse> ListIncompleteUploadsAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}