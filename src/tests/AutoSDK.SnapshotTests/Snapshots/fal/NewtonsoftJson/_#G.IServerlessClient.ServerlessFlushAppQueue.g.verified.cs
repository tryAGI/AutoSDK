//HintName: G.IServerlessClient.ServerlessFlushAppQueue.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Flush Application Queue<br/>
        /// Flushes all pending requests from an application's queue.<br/>
        /// **Authentication:** Required via API key<br/>
        /// **Idempotency:**<br/>
        /// - Optional `Idempotency-Key` header prevents duplicate flushes on retries<br/>
        /// - Responses cached for 10 minutes per unique key<br/>
        /// **Use Cases:**<br/>
        /// - Clear stuck or outdated requests from the queue<br/>
        /// - Reset queue state during development or testing<br/>
        /// - Cancel all pending requests for an application<br/>
        /// **Important:**<br/>
        /// - This operation is irreversible<br/>
        /// - All pending requests in the queue will be cancelled<br/>
        /// - Requests already being processed will not be affected
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ServerlessFlushAppQueueAsync(
            string owner,
            string name,
            string? idempotencyKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}