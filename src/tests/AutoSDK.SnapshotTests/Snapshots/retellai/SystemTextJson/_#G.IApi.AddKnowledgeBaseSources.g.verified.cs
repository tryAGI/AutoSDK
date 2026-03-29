//HintName: G.IApi.AddKnowledgeBaseSources.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Add sources to a knowledge base
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: kb_1234567890
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> AddKnowledgeBaseSourcesAsync(
            string knowledgeBaseId,

            global::G.KnowledgeBaseAddSourcesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add sources to a knowledge base
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: kb_1234567890
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> AddKnowledgeBaseSourcesAsync(
            string knowledgeBaseId,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseAddSourcesRequestKnowledgeBaseText>? knowledgeBaseTexts = default,
            global::System.Collections.Generic.IList<byte[]>? knowledgeBaseFiles = default,
            global::System.Collections.Generic.IList<string>? knowledgeBaseUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}