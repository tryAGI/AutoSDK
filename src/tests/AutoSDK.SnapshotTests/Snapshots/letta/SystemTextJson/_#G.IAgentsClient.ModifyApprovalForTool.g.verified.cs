//HintName: G.IAgentsClient.ModifyApprovalForTool.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Modify Approval For Tool<br/>
        /// Modify the approval requirement for a tool attached to an agent.<br/>
        /// Accepts requires_approval via request body (preferred) or query parameter (deprecated).
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requiresApproval">
        /// Whether the tool requires approval before execution
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ModifyApprovalForToolAsync(
            string toolName,
            string agentId,

            global::G.ModifyApprovalRequest request,
            bool? requiresApproval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Approval For Tool<br/>
        /// Modify the approval requirement for a tool attached to an agent.<br/>
        /// Accepts requires_approval via request body (preferred) or query parameter (deprecated).
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requiresApproval">
        /// Whether the tool requires approval before execution
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ModifyApprovalForToolAsync(
            string toolName,
            string agentId,
            bool? requiresApproval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}