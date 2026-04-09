//HintName: G.ITemplatesClient.TemplatesRenameTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Rename template (Cloud-only)<br/>
        /// Renames all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesRenameTemplateResponse> TemplatesRenameTemplateAsync(
            string projectId,
            string templateName,

            global::G.TemplatesRenameTemplateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename template (Cloud-only)<br/>
        /// Renames all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="newName">
        /// The new name for the template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesRenameTemplateResponse> TemplatesRenameTemplateAsync(
            string projectId,
            string templateName,
            string newName,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}