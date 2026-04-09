//HintName: G.IPromptsClient.PromptsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a prompt
        /// </summary>
        /// <param name="promptName"></param>
        /// <param name="version"></param>
        /// <param name="label"></param>
        /// <param name="resolve"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> PromptsGetAsync(
            string promptName,
            int? version = default,
            string? label = default,
            bool? resolve = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}