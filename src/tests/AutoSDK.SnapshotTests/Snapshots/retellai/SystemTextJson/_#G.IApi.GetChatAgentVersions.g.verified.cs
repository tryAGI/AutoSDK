//HintName: G.IApi.GetChatAgentVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get all versions of a chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ChatAgentResponse>> GetChatAgentVersionsAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}