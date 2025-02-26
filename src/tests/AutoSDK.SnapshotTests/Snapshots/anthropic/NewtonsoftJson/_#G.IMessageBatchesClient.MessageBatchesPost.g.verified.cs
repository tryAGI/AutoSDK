//HintName: G.IMessageBatchesClient.MessageBatchesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IMessageBatchesClient
    {
        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.<br/>
        /// The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> MessageBatchesPostAsync(
            global::G.CreateMessageBatchParams request,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Message Batch<br/>
        /// Send a batch of Message creation requests.<br/>
        /// The Message Batches API can be used to process multiple Messages API requests at once. Once a Message Batch is created, it begins processing immediately. Batches can take up to 24 hours to complete.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="requests">
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> MessageBatchesPostAsync(
            global::System.Collections.Generic.IList<global::G.MessageBatchIndividualRequestParams> requests,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}