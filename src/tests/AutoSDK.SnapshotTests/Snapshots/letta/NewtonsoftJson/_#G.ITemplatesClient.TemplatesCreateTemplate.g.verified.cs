//HintName: G.ITemplatesClient.TemplatesCreateTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateTemplateResponse> TemplatesCreateTemplateAsync(
            string projectId,

            global::G.TemplatesCreateTemplateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateTemplateResponse> TemplatesCreateTemplateAsync(
            string projectId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}