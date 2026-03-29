//HintName: G.IApi.DeleteChatAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete an existing chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChatAgentAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}