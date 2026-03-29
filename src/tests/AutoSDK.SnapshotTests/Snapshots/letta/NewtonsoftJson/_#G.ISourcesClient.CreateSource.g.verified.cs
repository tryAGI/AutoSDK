//HintName: G.ISourcesClient.CreateSource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Create Source<br/>
        /// Create a new data source.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Source2> CreateSourceAsync(

            global::G.SourceCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Source<br/>
        /// Create a new data source.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Source2> CreateSourceAsync(
            string name,
            string? description = default,
            string? instructions = default,
            object? metadata = default,
            string? embedding = default,
            int? embeddingChunkSize = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}