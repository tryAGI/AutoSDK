//HintName: G.IFoldersClient.ModifyFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Modify Folder<br/>
        /// Update the name or documentation of an existing data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Folder> ModifyFolderAsync(
            string folderId,

            global::G.SourceUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Folder<br/>
        /// Update the name or documentation of an existing data folder.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="name">
        /// The name of the source.
        /// </param>
        /// <param name="description">
        /// The description of the source.
        /// </param>
        /// <param name="instructions">
        /// Instructions for how to use the source.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the source.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the source.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Folder> ModifyFolderAsync(
            string folderId,
            string? name = default,
            string? description = default,
            string? instructions = default,
            object? metadata = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}