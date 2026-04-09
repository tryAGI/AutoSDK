//HintName: G.IPromptsClient.GetPromptId.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt<br/>
        /// Get a prompt object by its id
        /// </summary>
        /// <param name="promptId">
        /// Prompt id
        /// </param>
        /// <param name="version">
        /// Retrieve prompt at a specific version.<br/>
        /// The version id can either be a transaction id (e.g. '1000192656880881099') or a version identifier (e.g. '81cd05ee665fdfb3').
        /// </param>
        /// <param name="environment">
        /// Filter by environment slug. Cannot be used together with `version`.<br/>
        /// For `GET /v1/prompt`, environment resolution currently requires the request to match a single prompt. If multiple prompts match, the endpoint returns `400` (for example when `limit=1` is not set). Use `limit=1` or other filters (for example `slug`, `project_id`) to narrow results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prompt> GetPromptIdAsync(
            global::System.Guid promptId,
            string? version = default,
            string? environment = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}