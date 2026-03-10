//HintName: G.IAgentsPlatformClient.EditConvaiAgentsByAgentIdBranchesByBranchId.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Agent Branch<br/>
        /// Update agent branch properties such as archiving status and protection level
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBranchResponse> EditConvaiAgentsByAgentIdBranchesByBranchIdAsync(
            string agentId,
            string branchId,

            global::G.BodyUpdateAgentBranchV1ConvaiAgentsAgentIdBranchesBranchIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Agent Branch<br/>
        /// Update agent branch properties such as archiving status and protection level
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// New name for the branch. Must be unique within the agent.
        /// </param>
        /// <param name="isArchived">
        /// Whether the branch should be archived
        /// </param>
        /// <param name="protectionStatus">
        /// The protection level for the branch
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentBranchResponse> EditConvaiAgentsByAgentIdBranchesByBranchIdAsync(
            string agentId,
            string branchId,
            string? xiApiKey = default,
            string? name = default,
            bool? isArchived = default,
            global::G.BranchProtectionStatus? protectionStatus = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}