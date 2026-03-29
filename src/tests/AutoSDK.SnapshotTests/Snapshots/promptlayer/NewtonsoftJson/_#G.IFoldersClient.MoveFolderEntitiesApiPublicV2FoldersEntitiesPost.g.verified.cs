//HintName: G.IFoldersClient.MoveFolderEntitiesApiPublicV2FoldersEntitiesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Move Folder Entities<br/>
        /// Moves one or more entities into a target folder, or to the workspace root if no folder_id is provided. Supports moving folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Requires appropriate edit permissions for each entity type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FolderEntitiesCountResponse> MoveFolderEntitiesApiPublicV2FoldersEntitiesPostAsync(

            global::G.MoveFolderEntitiesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Folder Entities<br/>
        /// Moves one or more entities into a target folder, or to the workspace root if no folder_id is provided. Supports moving folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Requires appropriate edit permissions for each entity type.
        /// </summary>
        /// <param name="entities">
        /// List of entities to move.
        /// </param>
        /// <param name="folderId">
        /// The ID of the destination folder. If null or not provided, entities are moved to the workspace root.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FolderEntitiesCountResponse> MoveFolderEntitiesApiPublicV2FoldersEntitiesPostAsync(
            global::System.Collections.Generic.IList<global::G.EntityReference> entities,
            int? folderId = default,
            int? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}