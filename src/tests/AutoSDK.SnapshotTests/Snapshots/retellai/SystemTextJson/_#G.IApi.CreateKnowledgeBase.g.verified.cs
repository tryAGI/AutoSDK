//HintName: G.IApi.CreateKnowledgeBase.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> CreateKnowledgeBaseAsync(

            global::G.KnowledgeBaseRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="knowledgeBaseName">
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </param>
        /// <param name="knowledgeBaseTexts">
        /// Texts to add to the knowledge base.
        /// </param>
        /// <param name="knowledgeBaseFiles">
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </param>
        /// <param name="knowledgeBaseUrls">
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </param>
        /// <param name="enableAutoRefresh">
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxChunkSize">
        /// Maximum number of characters per chunk when splitting knowledge base. Default is 2000. content. Immutable after creation.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="minChunkSize">
        /// Minimum number of characters per chunk. Chunks smaller than this will be merged with adjacent chunks. Must be less than max_chunk_size. Immutable after creation. Default is 400.<br/>
        /// Example: 400
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> CreateKnowledgeBaseAsync(
            string knowledgeBaseName,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseRequestKnowledgeBaseText>? knowledgeBaseTexts = default,
            global::System.Collections.Generic.IList<byte[]>? knowledgeBaseFiles = default,
            global::System.Collections.Generic.IList<string>? knowledgeBaseUrls = default,
            bool? enableAutoRefresh = default,
            int? maxChunkSize = default,
            int? minChunkSize = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}