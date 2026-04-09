//HintName: G.ITemplatesClient.TemplatesListTemplateVersions.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List template versions (Cloud-only)<br/>
        /// List all versions of a specific template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesListTemplateVersionsResponse> TemplatesListTemplateVersionsAsync(
            string projectId,
            string name,
            global::G.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}