//HintName: G.IApi.UpdateConversationFlowComponent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update an existing shared conversation flow component
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationFlowComponentResponse> UpdateConversationFlowComponentAsync(
            string conversationFlowComponentId,

            global::G.ConversationFlowComponent request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing shared conversation flow component
        /// </summary>
        /// <param name="conversationFlowComponentId"></param>
        /// <param name="name">
        /// Name of the component<br/>
        /// Example: Customer Information Collector
        /// </param>
        /// <param name="tools">
        /// Tools available within the component<br/>
        /// Example: [{"type":"custom","name":"get_customer_info","description":"Get customer information from database","tool_id":"tool_001","url":"https://api.example.com/customer","method":"GET"}]
        /// </param>
        /// <param name="mcps">
        /// A list of MCP server configurations to use for this component
        /// </param>
        /// <param name="nodes">
        /// Nodes that make up the component<br/>
        /// Example: [{"id":"collect_info","type":"conversation","instruction":{"type":"prompt","text":"Ask the customer for their name and contact information."}}]
        /// </param>
        /// <param name="startNodeId">
        /// ID of the starting node<br/>
        /// Example: collect_info
        /// </param>
        /// <param name="beginTagDisplayPosition">
        /// Display position for the begin tag in the frontend
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConversationFlowComponentResponse> UpdateConversationFlowComponentAsync(
            string conversationFlowComponentId,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.NodeTool>? tools = default,
            global::System.Collections.Generic.IList<global::G.Mcp>? mcps = default,
            global::System.Collections.Generic.IList<global::G.ConversationFlowNode>? nodes = default,
            string? startNodeId = default,
            global::G.ConversationFlowComponentBeginTagDisplayPosition? beginTagDisplayPosition = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}