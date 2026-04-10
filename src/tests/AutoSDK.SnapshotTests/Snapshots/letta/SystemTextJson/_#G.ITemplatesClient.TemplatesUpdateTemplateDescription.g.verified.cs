//HintName: G.ITemplatesClient.TemplatesUpdateTemplateDescription.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update template description (Cloud-only)<br/>
        /// Updates the description for all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesUpdateTemplateDescriptionResponse> TemplatesUpdateTemplateDescriptionAsync(
            string projectId,
            string templateName,

            global::G.TemplatesUpdateTemplateDescriptionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update template description (Cloud-only)<br/>
        /// Updates the description for all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="description">
        /// The new description for the template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesUpdateTemplateDescriptionResponse> TemplatesUpdateTemplateDescriptionAsync(
            string projectId,
            string templateName,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}