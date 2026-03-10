//HintName: G.IAgentsPlatformClient.DeleteConvaiBatchCallingByBatchId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete A Batch Call.<br/>
        /// Permanently delete a batch call and all recipient records. Conversations remain in history.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConvaiBatchCallingByBatchIdAsync(
            string batchId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}