//HintName: G.IAgentsPlatformClient.DeleteConvaiAgentsByAgentIdDrafts.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Delete Agent Draft<br/>
        /// Delete a draft for an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// The ID of the agent branch to use
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConvaiAgentsByAgentIdDraftsAsync(
            string agentId,
            string branchId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}