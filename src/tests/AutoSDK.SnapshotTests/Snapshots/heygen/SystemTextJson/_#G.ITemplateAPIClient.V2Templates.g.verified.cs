//HintName: G.ITemplateApiClient.V2Templates.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateApiClient
    {
        /// <summary>
        /// v2/templates<br/>
        /// v2/templates
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TemplatesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}