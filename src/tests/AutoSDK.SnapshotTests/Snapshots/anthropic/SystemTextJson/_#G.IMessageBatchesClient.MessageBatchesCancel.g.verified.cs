//HintName: G.IMessageBatchesClient.MessageBatchesCancel.g.cs
#nullable enable

namespace G
{
    public partial interface IMessageBatchesClient
    {
        /// <summary>
        /// Cancel a Message Batch<br/>
        /// Batches may be canceled any time before processing ends. Once cancellation is initiated, the batch enters a `canceling` state, at which time the system may complete any in-progress, non-interruptible requests before finalizing cancellation.<br/>
        /// The number of canceled requests is specified in `request_counts`. To determine which requests were canceled, check the individual results within the batch. Note that cancellation may not result in any canceled requests if they were non-interruptible.<br/>
        /// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
        /// </summary>
        /// <param name="messageBatchId">
        /// ID of the Message Batch.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MessageBatch> MessageBatchesCancelAsync(
            string messageBatchId,
            string? anthropicVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}