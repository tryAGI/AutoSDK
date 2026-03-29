//HintName: G.IAgentsClient.ExportAgentWithSkills.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Export Agent With Skills<br/>
        /// Export the serialized JSON representation of an agent with optional skills.<br/>
        /// This POST endpoint allows including skills in the export by providing them in the request body.<br/>
        /// Skills are resolved client-side and passed as SkillSchema objects containing the skill files.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAgentWithSkillsAsync(
            string agentId,

            global::G.ExportAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Agent With Skills<br/>
        /// Export the serialized JSON representation of an agent with optional skills.<br/>
        /// This POST endpoint allows including skills in the export by providing them in the request body.<br/>
        /// Skills are resolved client-side and passed as SkillSchema objects containing the skill files.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportAgentWithSkillsAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}