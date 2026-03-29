//HintName: G.IPageFiguresClient.GetFilePageFigureApiV1FilesIdPageFiguresPageIndexFigureNameGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPageFiguresClient
    {
        /// <summary>
        /// Get File Page Figure<br/>
        /// Get a specific figure from a page of a file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageIndex"></param>
        /// <param name="figureName"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilePageFigureApiV1FilesIdPageFiguresPageIndexFigureNameGetAsync(
            global::System.Guid id,
            int pageIndex,
            string figureName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}