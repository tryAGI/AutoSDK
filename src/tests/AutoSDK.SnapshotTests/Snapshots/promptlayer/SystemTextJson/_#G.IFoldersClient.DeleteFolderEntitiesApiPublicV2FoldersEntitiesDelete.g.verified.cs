//HintName: G.IFoldersClient.DeleteFolderEntitiesApiPublicV2FoldersEntitiesDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Delete Folder Entities<br/>
        /// Deletes one or more entities from the workspace. Supports deleting folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Use cascade=true to recursively delete all contents of a folder. Without cascade, deleting a non-empty folder returns an error. Entities are soft-deleted where applicable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FolderEntitiesCountResponse> DeleteFolderEntitiesApiPublicV2FoldersEntitiesDeleteAsync(

            global::G.DeleteFolderEntitiesRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Folder Entities<br/>
        /// Deletes one or more entities from the workspace. Supports deleting folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Use cascade=true to recursively delete all contents of a folder. Without cascade, deleting a non-empty folder returns an error. Entities are soft-deleted where applicable.
        /// </summary>
        /// <param name="entities">
        /// List of entities to delete.
        /// </param>
        /// <param name="cascade">
        /// When true, recursively deletes all contents of any folders in the entities list. When false, attempting to delete a non-empty folder returns an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FolderEntitiesCountResponse> DeleteFolderEntitiesApiPublicV2FoldersEntitiesDeleteAsync(
            global::System.Collections.Generic.IList<global::G.EntityReference> entities,
            bool? cascade = default,
            int? workspaceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}