//HintName: G.ICorsClient.OptionsProjectAutomationId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/project_automation/{project_automation_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}