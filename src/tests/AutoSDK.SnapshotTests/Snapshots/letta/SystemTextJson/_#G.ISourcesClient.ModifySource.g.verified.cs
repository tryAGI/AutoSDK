//HintName: G.ISourcesClient.ModifySource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Modify Source<br/>
        /// Update the name or documentation of an existing data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Source2> ModifySourceAsync(
            string sourceId,

            global::G.SourceUpdate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Source<br/>
        /// Update the name or documentation of an existing data source.
        /// </summary>
        /// <param name="sourceId">
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Source2> ModifySourceAsync(
            string sourceId,
            string? name = default,
            string? description = default,
            string? instructions = default,
            object? metadata = default,
            global::G.EmbeddingConfig? embeddingConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}