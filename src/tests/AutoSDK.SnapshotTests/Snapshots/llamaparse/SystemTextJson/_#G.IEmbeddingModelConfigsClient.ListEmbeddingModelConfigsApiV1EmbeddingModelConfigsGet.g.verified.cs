//HintName: G.IEmbeddingModelConfigsClient.ListEmbeddingModelConfigsApiV1EmbeddingModelConfigsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingModelConfigsClient
    {
        /// <summary>
        /// List Embedding Model Configs
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.EmbeddingModelConfig>> ListEmbeddingModelConfigsApiV1EmbeddingModelConfigsGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}