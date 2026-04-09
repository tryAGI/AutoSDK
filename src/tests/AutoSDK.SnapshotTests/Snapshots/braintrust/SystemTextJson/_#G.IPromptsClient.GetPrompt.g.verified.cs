//HintName: G.IPromptsClient.GetPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// List prompts<br/>
        /// List out all prompts. The prompts are sorted by creation date, with the most recently-created prompts coming first
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return
        /// </param>
        /// <param name="startingAfter">
        /// Pagination cursor id.<br/>
        /// For example, if the final item in the last page you fetched had an id of `foo`, pass `starting_after=foo` to fetch the next page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="endingBefore">
        /// Pagination cursor id.<br/>
        /// For example, if the initial item in the last page you fetched had an id of `foo`, pass `ending_before=foo` to fetch the previous page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="ids">
        /// Filter search results to a particular set of object IDs. To specify a list of IDs, include the query param multiple times
        /// </param>
        /// <param name="promptName">
        /// Name of the prompt to search for
        /// </param>
        /// <param name="projectName">
        /// Name of the project to search for
        /// </param>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="slug">
        /// Retrieve prompt with a specific slug
        /// </param>
        /// <param name="version">
        /// Retrieve prompt at a specific version.<br/>
        /// The version id can either be a transaction id (e.g. '1000192656880881099') or a version identifier (e.g. '81cd05ee665fdfb3').
        /// </param>
        /// <param name="environment">
        /// Filter by environment slug. Cannot be used together with `version`.<br/>
        /// For `GET /v1/prompt`, environment resolution currently requires the request to match a single prompt. If multiple prompts match, the endpoint returns `400` (for example when `limit=1` is not set). Use `limit=1` or other filters (for example `slug`, `project_id`) to narrow results.
        /// </param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetPromptResponse> GetPromptAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::G.Ids? ids = default,
            string? promptName = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? slug = default,
            string? version = default,
            string? environment = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}