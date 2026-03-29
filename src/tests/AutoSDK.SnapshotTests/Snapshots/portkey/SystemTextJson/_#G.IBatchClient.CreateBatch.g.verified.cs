//HintName: G.IBatchClient.CreateBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Batch> CreateBatchAsync(

            global::G.AnyOf<global::G.OpenAIBatchJob, global::G.BedrockBatchJob, global::G.VertexBatchJob, global::G.PortkeyBatchJob> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Batch> CreateBatchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}