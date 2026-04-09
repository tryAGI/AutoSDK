//HintName: G.IEmbeddingModelConfigsClient.DeleteEmbeddingModelConfigApiV1EmbeddingModelConfigsEmbeddingModelConfigIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingModelConfigsClient
    {
        /// <summary>
        /// Delete Embedding Model Config<br/>
        /// Delete an embedding model config by ID.
        /// </summary>
        /// <param name="embeddingModelConfigId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEmbeddingModelConfigApiV1EmbeddingModelConfigsEmbeddingModelConfigIdDeleteAsync(
            global::System.Guid embeddingModelConfigId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}