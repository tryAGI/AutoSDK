//HintName: G.IKnowledgeClient.Get1.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Get Knowledges<br/>
        /// Get all user knowledge bases
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Get1ResponseItem>> Get1Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}