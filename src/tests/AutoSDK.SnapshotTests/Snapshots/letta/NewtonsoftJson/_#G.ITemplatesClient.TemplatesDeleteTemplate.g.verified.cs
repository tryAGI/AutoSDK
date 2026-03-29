//HintName: G.ITemplatesClient.TemplatesDeleteTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Delete template (Cloud-only)<br/>
        /// Deletes all versions of a template with the specified name
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesDeleteTemplateResponse> TemplatesDeleteTemplateAsync(
            string projectId,
            string templateName,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete template (Cloud-only)<br/>
        /// Deletes all versions of a template with the specified name
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesDeleteTemplateResponse> TemplatesDeleteTemplateAsync(
            string projectId,
            string templateName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}