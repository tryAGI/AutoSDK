//HintName: G.IAgentsClient.CloseFileForAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Close File For Agent<br/>
        /// Closes a specific file for a given agent.<br/>
        /// This endpoint marks a specific file as closed in the agent's file state.<br/>
        /// The file will be removed from the agent's working memory view.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file in the format 'file-&lt;uuid4&gt;'
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CloseFileForAgentAsync(
            string fileId,
            string agentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}