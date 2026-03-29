//HintName: G.IPageFiguresClient.ListFilePagesFiguresApiV1FilesIdPageFiguresGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPageFiguresClient
    {
        /// <summary>
        /// List File Pages Figures<br/>
        /// List metadata for all figures from all pages of a file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PageFigureMetadata>> ListFilePagesFiguresApiV1FilesIdPageFiguresGetAsync(
            global::System.Guid id,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}