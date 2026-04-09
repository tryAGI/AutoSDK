//HintName: G.ITagClient.GetProjectTagsExportFileURLJobId.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetProjectTagsExportFileURLJobId<br/>
        /// GetProjectTagsExportFileURLJobId
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportFileURLJobIdAsync(

            global::G.GetProjectTagsExportFileURLJobIdRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GetProjectTagsExportFileURLJobId<br/>
        /// GetProjectTagsExportFileURLJobId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportFileURLJobIdAsync(
            global::System.Guid projectId,
            string fileExtension,
            bool includeExcerpts,
            string encryptedSymKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}