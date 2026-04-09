//HintName: G.IProjectAutomationsClient.PostProjectAutomation.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Create project_automation<br/>
        /// Create a new project_automation. If there is an existing project_automation with the same name as the one specified in the request, will return the existing project_automation unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectAutomation> PostProjectAutomationAsync(

            global::G.CreateProjectAutomation request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_automation<br/>
        /// Create a new project_automation. If there is an existing project_automation with the same name as the one specified in the request, will return the existing project_automation unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project automation belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the automation rule
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectAutomation> PostProjectAutomationAsync(
            global::System.Guid projectId,
            string name,
            global::G.AnyOf<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> config,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}