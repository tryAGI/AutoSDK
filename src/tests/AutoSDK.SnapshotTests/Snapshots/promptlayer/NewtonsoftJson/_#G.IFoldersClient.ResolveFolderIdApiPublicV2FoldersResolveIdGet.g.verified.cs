//HintName: G.IFoldersClient.ResolveFolderIdApiPublicV2FoldersResolveIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Resolve Folder ID by Path<br/>
        /// Resolves a folder's ID from its path. The path uses dot-separated folder names representing the hierarchy (e.g., "My Folder.Subfolder").
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace containing the folder.
        /// </param>
        /// <param name="path">
        /// Dot-separated folder path to resolve (e.g., "My Folder.Subfolder").
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResolveFolderIdResponse> ResolveFolderIdApiPublicV2FoldersResolveIdGetAsync(
            int workspaceId,
            string path,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}