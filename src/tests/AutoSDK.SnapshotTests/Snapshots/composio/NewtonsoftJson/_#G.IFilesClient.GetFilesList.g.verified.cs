//HintName: G.IFilesClient.GetFilesList.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List files with optional app and action filters<br/>
        /// Retrieves a list of files associated with the authenticated project. Results can be filtered by toolkit and tool slugs.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Filter files by app slug. Example: "file-converter"
        /// </param>
        /// <param name="toolSlug">
        /// Filter files by action slug. Example: "convert-to-pdf"
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetFilesListResponse> GetFilesListAsync(
            string? toolkitSlug = default,
            string? toolSlug = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}