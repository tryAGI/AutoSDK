//HintName: G.IFileApiClient.GatewayRetryFailedFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Retry failed files<br/>
        /// Retry processing of files that previously failed to process. This will re-attempt the processing of the specified files.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/files/retry \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        ///  --data-raw '{"file_ids":["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e", "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e", "182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"]}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.RetryFilesResponse> GatewayRetryFailedFilesAsync(

            global::G.RetryFilesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retry failed files<br/>
        /// Retry processing of files that previously failed to process. This will re-attempt the processing of the specified files.
        /// </summary>
        /// <param name="fileIds">
        /// The unique identifier of the files to retry.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetryFilesResponse> GatewayRetryFailedFilesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}