//HintName: G.IProjectAutomationsClient.GetProjectAutomationId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Get project_automation<br/>
        /// Get a project_automation object by its id
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectAutomation> GetProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}