//HintName: G.IMemoClient.LoadProjectMemosFoldersAndLinks.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// LoadProjectMemosFoldersAndLinks<br/>
        /// LoadProjectMemosFoldersAndLinks
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemosFoldersAndLinks> LoadProjectMemosFoldersAndLinksAsync(
            global::G.LoadProjectMemosFoldersAndLinksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LoadProjectMemosFoldersAndLinks<br/>
        /// LoadProjectMemosFoldersAndLinks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemosFoldersAndLinks> LoadProjectMemosFoldersAndLinksAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}