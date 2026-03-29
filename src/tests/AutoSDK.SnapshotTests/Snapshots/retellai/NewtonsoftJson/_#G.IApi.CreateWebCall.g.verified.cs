//HintName: G.IApi.CreateWebCall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new web call
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2WebCallResponse> CreateWebCallAsync(

            global::G.CreateWebCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new web call
        /// </summary>
        /// <param name="agentId">
        /// Unique id of agent used for the call. Your agent would contain the LLM Websocket url used for this call.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="agentVersion">
        /// The version of the agent to use for the call.<br/>
        /// Example: 1
        /// </param>
        /// <param name="agentOverride">
        /// Override configuration for agent, retell LLM, or conversation flow settings for a specific call.
        /// </param>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the call. Not used for processing. You can later get this field from the call object.
        /// </param>
        /// <param name="retellLlmDynamicVariables">
        /// Add optional dynamic variables in key value pairs of string that injects into your Response Engine prompt and tool description. Only applicable for Response Engine.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="currentNodeId">
        /// Start the call at this conversation flow node (stage). Must be a valid node id in the agent's conversation flow. Only applicable when the agent uses conversation flow as the response engine. Ignored for retell-llm agents.<br/>
        /// Example: collect_info
        /// </param>
        /// <param name="currentState">
        /// Start the conversation in this state (stage). Must be a valid state name in the agent's Retell LLM. Only applicable when the agent uses Retell LLM with states. Ignored for conversation-flow agents.<br/>
        /// Example: information_collection
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V2WebCallResponse> CreateWebCallAsync(
            string agentId,
            int? agentVersion = default,
            global::G.AgentOverrideRequest? agentOverride = default,
            object? metadata = default,
            object? retellLlmDynamicVariables = default,
            string? currentNodeId = default,
            string? currentState = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}