//HintName: G.ISubpackageMultipartUploadClient.GetStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// Retrieve the status of an upload session<br/>
        /// This method provides information about an upload session, including its current status, chunk-level progress, and completion state.<br/>
        /// Use this method to:<br/>
        /// - Verify upload completion (`status` = `completed`)<br/>
        /// - Identify any failed chunks that require a retry<br/>
        /// - Monitor the upload progress by comparing `uploaded_size` with `total_size`<br/>
        /// - Determine if the session has expired<br/>
        /// - Retrieve the status information for each chunk<br/>
        /// You must call this method after reporting chunk completion to confirm the upload has transitioned to the `completed` status before using the asset.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUploadStatusResponse> GetStatusAsync(
            string uploadId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}