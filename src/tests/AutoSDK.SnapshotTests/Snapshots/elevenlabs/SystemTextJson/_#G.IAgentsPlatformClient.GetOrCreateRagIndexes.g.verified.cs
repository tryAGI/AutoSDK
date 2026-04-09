//HintName: G.IAgentsPlatformClient.GetOrCreateRagIndexes.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Compute Rag Indexes In Batch<br/>
        /// Retrieves and/or creates RAG indexes for multiple knowledge base documents in a single request. Maximum 100 items per request.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrCreateRagIndexesAsync(

            global::G.BodyComputeRagIndexesInBatchV1ConvaiKnowledgeBaseRagIndexPost request,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute Rag Indexes In Batch<br/>
        /// Retrieves and/or creates RAG indexes for multiple knowledge base documents in a single request. Maximum 100 items per request.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="items">
        /// List of requested RAG indexes. Minimum 1, maximum 100 items.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrCreateRagIndexesAsync(
            global::System.Collections.Generic.IList<global::G.GetOrCreateRAGIndexRequestModel> items,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}