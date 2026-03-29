//HintName: G.ISubpackageEmbeddingsClient.ListEmbeddingsModels.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbeddingsClient
    {
        /// <summary>
        /// List all embeddings models<br/>
        /// Returns a list of all available embeddings models and their properties
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsListResponse> ListEmbeddingsModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}