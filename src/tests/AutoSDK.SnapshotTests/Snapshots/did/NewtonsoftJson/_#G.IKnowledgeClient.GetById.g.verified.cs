//HintName: G.IKnowledgeClient.GetById.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get a Knowledge<br/>
        /// Get specific knowledge base
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetByIdResponse> GetByIdAsync(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}