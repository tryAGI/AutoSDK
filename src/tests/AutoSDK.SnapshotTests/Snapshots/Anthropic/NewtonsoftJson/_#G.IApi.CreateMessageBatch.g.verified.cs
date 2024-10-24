//HintName: G.IApi.CreateMessageBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> CreateMessageBatchAsync(
            global::G.CreateMessageBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.
        /// </summary>
        /// <param name="requests">
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> CreateMessageBatchAsync(
            global::System.Collections.Generic.IList<global::G.BatchMessageRequest> requests,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}