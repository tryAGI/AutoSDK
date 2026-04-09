//HintName: G.IProjectAutomationsClient.GetProjectAutomation.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// List project_automations<br/>
        /// List out all project_automations. The project_automations are sorted by creation date, with the most recently-created project_automations coming first
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
        /// <param name="projectAutomationName">
        /// Name of the project_automation to search for
        /// </param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectAutomationResponse> GetProjectAutomationAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::G.Ids? ids = default,
            string? projectAutomationName = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}