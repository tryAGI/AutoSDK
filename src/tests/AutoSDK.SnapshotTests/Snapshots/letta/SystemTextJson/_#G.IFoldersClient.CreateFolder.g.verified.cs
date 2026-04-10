//HintName: G.IFoldersClient.CreateFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Create Folder<br/>
        /// Create a new data folder.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Folder> CreateFolderAsync(

            global::G.SourceCreate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Folder<br/>
        /// Create a new data folder.
        /// </summary>
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
        /// <param name="embedding">
        /// The handle for the embedding config used by the source.
        /// </param>
        /// <param name="embeddingChunkSize">
        /// The chunk size of the embedding.
        /// </param>
        /// <param name="embeddingConfig">
        /// (Legacy) The embedding configuration used by the source.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Folder> CreateFolderAsync(
            string name,
            string? description = default,
            string? instructions = default,
            object? metadata = default,
            string? embedding = default,
            int? embeddingChunkSize = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}