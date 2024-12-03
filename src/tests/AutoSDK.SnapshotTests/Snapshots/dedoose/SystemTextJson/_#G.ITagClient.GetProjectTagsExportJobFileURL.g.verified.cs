//HintName: G.ITagClient.GetProjectTagsExportJobFileURL.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetProjectTagsExportJobFileURL<br/>
        /// GetProjectTagsExportJobFileURL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportJobFileURLAsync(
            global::G.GetProjectTagsExportJobFileURLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectTagsExportJobFileURL<br/>
        /// GetProjectTagsExportJobFileURL
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportJobFileURLAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}