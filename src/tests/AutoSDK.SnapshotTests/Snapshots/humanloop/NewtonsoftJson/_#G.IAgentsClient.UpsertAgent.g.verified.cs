//HintName: G.IAgentsClient.UpsertAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Upsert Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> UpsertAgentAsync(

            global::G.AgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Agent
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="template"></param>
        /// <param name="tools"></param>
        /// <param name="linkedTools"></param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> UpsertAgentAsync(
            string? path = default,
            string? id = default,
            string? model = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? template = default,
            global::System.Collections.Generic.IList<global::G.ToolFunction>? tools = default,
            global::System.Collections.Generic.IList<string>? linkedTools = default,
            object? attributes = default,
            string? versionName = default,
            string? versionDescription = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            double? temperature = default,
            int? maxTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}