//HintName: G.IProjectAutomationsClient.PatchProjectAutomationId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Partially update project_automation<br/>
        /// Partially update a project_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectAutomation> PatchProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,

            global::G.PatchProjectAutomation request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_automation<br/>
        /// Partially update a project_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
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
        global::System.Threading.Tasks.Task<global::G.ProjectAutomation> PatchProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            string? name = default,
            string? description = default,
            global::G.AnyOf<global::G.PatchProjectAutomationConfigVariant1, global::G.PatchProjectAutomationConfigVariant2, global::G.PatchProjectAutomationConfigVariant3, global::G.PatchProjectAutomationConfigVariant4, global::G.TopicAutomationConfig, object>? config = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}