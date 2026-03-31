//HintName: G.IKnowledgeClient.Delete1.g.cs
#nullable enable

namespace G
{
    public partial interface IKnowledgeClient
    {
        /// <summary>
        /// Delete a Knowledge<br/>
        /// Knowledge will be deleted with all documents in it. Knowledge that was deleted will no longer be available for any agent.
        /// </summary>
        /// <param name="knowledgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Delete1Response4> Delete1Async(
            string knowledgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}