//HintName: G.ITagClient.TagGetProjectTagsExportFileURLJobId.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetProjectTagsExportFileURLJobId.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="includeExcerpts"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TagGetProjectTagsExportFileURLJobIdAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? fileExtension = default,
            bool? includeExcerpts = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}