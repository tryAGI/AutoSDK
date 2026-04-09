//HintName: G.ITemplatesClient.TemplatesMigrateDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Migrate deployment to template version (Cloud-only)<br/>
        /// Migrates a deployment to a specific template version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesMigrateDeploymentResponse> TemplatesMigrateDeploymentAsync(
            string projectId,
            string templateName,
            string deploymentId,

            global::G.TemplatesMigrateDeploymentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Migrate deployment to template version (Cloud-only)<br/>
        /// Migrates a deployment to a specific template version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="version">
        /// The target template version to migrate to
        /// </param>
        /// <param name="preserveToolVariables">
        /// Whether to preserve existing tool variables during migration
        /// </param>
        /// <param name="preserveCoreMemories">
        /// Whether to preserve existing core memories during migration
        /// </param>
        /// <param name="preserveSources">
        /// If true, existing agent sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="memoryVariables">
        /// Additional memory variables to apply during migration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesMigrateDeploymentResponse> TemplatesMigrateDeploymentAsync(
            string projectId,
            string templateName,
            string deploymentId,
            string version,
            bool? preserveToolVariables = default,
            bool? preserveCoreMemories = default,
            bool? preserveSources = default,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}