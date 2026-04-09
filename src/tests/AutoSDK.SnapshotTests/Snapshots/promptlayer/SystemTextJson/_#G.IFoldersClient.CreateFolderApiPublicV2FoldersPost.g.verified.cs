//HintName: G.IFoldersClient.CreateFolderApiPublicV2FoldersPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Create Folder<br/>
        /// Creates a new folder in the workspace. Folders can be nested within other folders by providing a parent_id. The folder name must be unique within its parent folder (or at the root level if no parent is specified).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFolderSuccessResponse> CreateFolderApiPublicV2FoldersPostAsync(

            global::G.CreateFolderRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Creates a new folder in the workspace. Folders can be nested within other folders by providing a parent_id. The folder name must be unique within its parent folder (or at the root level if no parent is specified).
        /// </summary>
        /// <param name="name">
        /// The name of the folder. Must be unique within its parent folder.
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent folder. If null or not provided, the folder will be created at the root level of the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFolderSuccessResponse> CreateFolderApiPublicV2FoldersPostAsync(
            string name,
            int? parentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}