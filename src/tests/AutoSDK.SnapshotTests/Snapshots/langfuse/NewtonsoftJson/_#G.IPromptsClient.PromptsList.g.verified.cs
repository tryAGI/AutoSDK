//HintName: G.IPromptsClient.PromptsList.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get a list of prompt names with versions and labels
        /// </summary>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="tag"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="fromUpdatedAt"></param>
        /// <param name="toUpdatedAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptMetaListResponse> PromptsListAsync(
            string? name = default,
            string? label = default,
            string? tag = default,
            int? page = default,
            int? limit = default,
            global::System.DateTime? fromUpdatedAt = default,
            global::System.DateTime? toUpdatedAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}