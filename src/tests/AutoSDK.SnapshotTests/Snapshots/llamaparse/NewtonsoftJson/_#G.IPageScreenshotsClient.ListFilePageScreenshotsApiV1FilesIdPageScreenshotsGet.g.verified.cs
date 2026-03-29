//HintName: G.IPageScreenshotsClient.ListFilePageScreenshotsApiV1FilesIdPageScreenshotsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPageScreenshotsClient
    {
        /// <summary>
        /// List File Page Screenshots<br/>
        /// List metadata for all screenshots of pages from a file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PageScreenshotMetadata>> ListFilePageScreenshotsApiV1FilesIdPageScreenshotsGetAsync(
            global::System.Guid id,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}