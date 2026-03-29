//HintName: G.IAgentsClient.RecompileAgentSystemPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Recompile Agent System Prompt<br/>
        /// Deprecated alias for POST /v1/agents/{agent_id}/recompile.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="updateTimestamp">
        /// If True, update the in-context memory last edit timestamp embedded in the system prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dryRun">
        /// If True, do not persist changes; still returns the compiled system prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<string> RecompileAgentSystemPromptAsync(
            string agentId,
            bool? updateTimestamp = default,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}