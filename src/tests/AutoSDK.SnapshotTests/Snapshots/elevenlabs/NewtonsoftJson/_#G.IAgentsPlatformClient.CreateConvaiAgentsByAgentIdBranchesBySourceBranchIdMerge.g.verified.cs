//HintName: G.IAgentsPlatformClient.CreateConvaiAgentsByAgentIdBranchesBySourceBranchIdMerge.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="sourceBranchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the target branch to merge into (must be the main branch).
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiAgentsByAgentIdBranchesBySourceBranchIdMergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,

            global::G.BodyMergeABranchIntoATargetBranchV1ConvaiAgentsAgentIdBranchesSourceBranchIdMergePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Merge A Branch Into A Target Branch<br/>
        /// Merge a branch into a target branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="sourceBranchId">
        /// Unique identifier for the source branch to merge from.
        /// </param>
        /// <param name="targetBranchId">
        /// The ID of the target branch to merge into (must be the main branch).
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="archiveSourceBranch">
        /// Whether to archive the source branch after merging<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConvaiAgentsByAgentIdBranchesBySourceBranchIdMergeAsync(
            string agentId,
            string sourceBranchId,
            string targetBranchId,
            string? xiApiKey = default,
            bool? archiveSourceBranch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}