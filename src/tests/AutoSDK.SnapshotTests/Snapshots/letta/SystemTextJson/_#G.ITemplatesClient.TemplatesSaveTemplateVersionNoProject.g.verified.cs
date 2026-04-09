//HintName: G.ITemplatesClient.TemplatesSaveTemplateVersionNoProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Save template version (Cloud-only)<br/>
        /// Saves the current version of the template as a new version
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesSaveTemplateVersionNoProjectResponse> TemplatesSaveTemplateVersionNoProjectAsync(
            string templateName,

            global::G.TemplatesSaveTemplateVersionNoProjectRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save template version (Cloud-only)<br/>
        /// Saves the current version of the template as a new version
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="preserveEnvironmentVariablesOnMigration">
        /// If true, the environment variables will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveCoreMemoriesOnMigration">
        /// If true, the core memories will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveSourcesOnMigration">
        /// If true, existing agent folders/sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="blockReconciliationStrategy">
        /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </param>
        /// <param name="migrateAgents">
        /// If true, existing agents attached to this template will be migrated to the new template version
        /// </param>
        /// <param name="message">
        /// A message to describe the changes made in this template version
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesSaveTemplateVersionNoProjectResponse> TemplatesSaveTemplateVersionNoProjectAsync(
            string templateName,
            bool? preserveEnvironmentVariablesOnMigration = default,
            bool? preserveCoreMemoriesOnMigration = default,
            bool? preserveSourcesOnMigration = default,
            global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy? blockReconciliationStrategy = default,
            bool? migrateAgents = default,
            string? message = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}