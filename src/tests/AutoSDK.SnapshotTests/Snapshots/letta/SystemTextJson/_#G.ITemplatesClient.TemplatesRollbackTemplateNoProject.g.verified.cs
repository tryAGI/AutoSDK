//HintName: G.ITemplatesClient.TemplatesRollbackTemplateNoProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Rollback template to previous version (Cloud-only)<br/>
        /// Rollback the current working version of a template to a previous saved version. If the current version has unsaved changes, they will be automatically saved as a new version before rollback.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesRollbackTemplateNoProjectResponse> TemplatesRollbackTemplateNoProjectAsync(
            string templateName,

            global::G.TemplatesRollbackTemplateNoProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rollback template to previous version (Cloud-only)<br/>
        /// Rollback the current working version of a template to a previous saved version. If the current version has unsaved changes, they will be automatically saved as a new version before rollback.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="version">
        /// The target version to rollback to (e.g., "1", "2", "latest"). Cannot be "current" or "dev".
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesRollbackTemplateNoProjectResponse> TemplatesRollbackTemplateNoProjectAsync(
            string templateName,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}