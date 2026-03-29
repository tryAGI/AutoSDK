//HintName: G.IApi.CreateChatAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new chat agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatAgentResponse> CreateChatAgentAsync(

            global::G.AllOf<global::G.ChatAgentRequest, object> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new chat agent
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatAgentResponse> CreateChatAgentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}