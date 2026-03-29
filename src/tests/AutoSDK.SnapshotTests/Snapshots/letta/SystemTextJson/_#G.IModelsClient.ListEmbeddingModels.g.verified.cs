//HintName: G.IModelsClient.ListEmbeddingModels.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Embedding Models<br/>
        /// List available embedding models using the asynchronous implementation for improved performance.<br/>
        /// Returns EmbeddingModel format which extends EmbeddingConfig with additional metadata fields.<br/>
        /// Legacy EmbeddingConfig fields are marked as deprecated but still available for backward compatibility.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.EmbeddingModel>> ListEmbeddingModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}