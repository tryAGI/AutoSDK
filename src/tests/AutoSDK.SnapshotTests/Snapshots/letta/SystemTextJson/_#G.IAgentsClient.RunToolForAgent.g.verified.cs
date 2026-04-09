//HintName: G.IAgentsClient.RunToolForAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Run Tool For Agent<br/>
        /// Trigger a tool by name on a specific agent, providing the necessary arguments.<br/>
        /// This endpoint executes a tool that is attached to the agent, using the agent's<br/>
        /// state and environment variables for execution context.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="toolName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolExecutionResult> RunToolForAgentAsync(
            string agentId,
            string toolName,

            global::G.LettaSchemasMcpServerToolExecuteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Tool For Agent<br/>
        /// Trigger a tool by name on a specific agent, providing the necessary arguments.<br/>
        /// This endpoint executes a tool that is attached to the agent, using the agent's<br/>
        /// state and environment variables for execution context.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="toolName"></param>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolExecutionResult> RunToolForAgentAsync(
            string agentId,
            string toolName,
            object? args = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}