//HintName: G.IApi.GetKnowledgeBase.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve details of a specific knowledge base
        /// </summary>
        /// <param name="knowledgeBaseId">
        /// Example: kb_1234567890
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> GetKnowledgeBaseAsync(
            string knowledgeBaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}