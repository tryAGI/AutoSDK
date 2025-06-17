//HintName: G.IConversationalAIClient.CreateConvaiBatchCallingByBatchIdRetry.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Retry A Batch Call.<br/>
        /// Retry a batch call by setting completed recipients back to pending status.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchCallResponse> CreateConvaiBatchCallingByBatchIdRetryAsync(
            string batchId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}