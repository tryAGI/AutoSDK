//HintName: G.IExperimentsClient.GetExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// List experiments<br/>
        /// List out all experiments. The experiments are sorted by creation date, with the most recently-created experiments coming first
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return<br/>
        /// Default Value: 1000
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
        /// <param name="experimentName">
        /// Name of the experiment to search for
        /// </param>
        /// <param name="projectName">
        /// Name of the project to search for
        /// </param>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetExperimentResponse> GetExperimentAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::G.Ids? ids = default,
            string? experimentName = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? orgName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}