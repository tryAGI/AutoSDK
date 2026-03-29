//HintName: G.IFoldersClient.ListFolderEntitiesApiPublicV2FoldersEntitiesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// List Folder Entities<br/>
        /// Lists entities within a folder or at the workspace root. Returns folders, prompts, snippets, workflows, datasets, evaluations, AB tests, and input variable sets. Supports filtering by entity type, searching by name, flattening the folder hierarchy, and optionally including entity metadata.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace to list entities from.
        /// </param>
        /// <param name="folderId">
        /// The ID of the folder to list entities from. If not provided, lists entities at the workspace root level.
        /// </param>
        /// <param name="filterType">
        /// Filter entities by type. Can be a single type or a list of types. If not provided, all entity types are returned.
        /// </param>
        /// <param name="searchQuery">
        /// Search entities by name (case-insensitive partial match).
        /// </param>
        /// <param name="flatten">
        /// When true, returns all entities recursively within the folder hierarchy instead of only direct children.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeMetadata">
        /// When true, includes type-specific metadata for each entity (e.g., prompt type, latest version number).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFolderEntitiesResponse> ListFolderEntitiesApiPublicV2FoldersEntitiesGetAsync(
            int workspaceId,
            int? folderId = default,
            global::G.OneOf<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterType2?, global::System.Collections.Generic.IList<global::G.ListFolderEntitiesApiPublicV2FoldersEntitiesGetFilterTypeItem>>? filterType = default,
            string? searchQuery = default,
            bool? flatten = default,
            bool? includeMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}