//HintName: G.ITemplatesClient.TemplatesListTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List templates (Cloud-only)<br/>
        /// List all templates
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="exact"></param>
        /// <param name="limit"></param>
        /// <param name="version"></param>
        /// <param name="templateId"></param>
        /// <param name="name"></param>
        /// <param name="search"></param>
        /// <param name="projectSlug"></param>
        /// <param name="projectId"></param>
        /// <param name="sortBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesListTemplatesResponse> TemplatesListTemplatesAsync(
            global::G.OneOf<string, double?>? offset = default,
            string? exact = default,
            string? limit = default,
            string? version = default,
            string? templateId = default,
            string? name = default,
            string? search = default,
            string? projectSlug = default,
            string? projectId = default,
            global::G.TemplatesListTemplatesSortBy? sortBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}