//HintName: G.IFoldersClient.UpdateFolderApiPublicV2FoldersPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Update Folder<br/>
        /// Renames an existing folder. The new name must be unique within the folder's parent (or at root level). The folder must belong to a workspace accessible by the authenticated user.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the folder to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFolderSuccessResponse> UpdateFolderApiPublicV2FoldersPatchAsync(
            int folderId,

            global::G.UpdateFolderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Folder<br/>
        /// Renames an existing folder. The new name must be unique within the folder's parent (or at root level). The folder must belong to a workspace accessible by the authenticated user.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the folder to update.
        /// </param>
        /// <param name="name">
        /// The new name for the folder. Must be unique within its parent folder.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFolderSuccessResponse> UpdateFolderApiPublicV2FoldersPatchAsync(
            int folderId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}