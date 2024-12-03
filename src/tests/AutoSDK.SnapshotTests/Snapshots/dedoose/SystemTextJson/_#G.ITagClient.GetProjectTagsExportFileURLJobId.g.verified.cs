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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportFileURLJobIdAsync(
            global::G.GetProjectTagsExportFileURLJobIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectTagsExportFileURLJobId<br/>
        /// GetProjectTagsExportFileURLJobId
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetProjectTagsExportFileURLJobIdAsync(
            global::System.Guid projectId,
            string fileExtension,
            bool includeExcerpts,
            string encryptedSymKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}