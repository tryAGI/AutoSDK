//HintName: G.IBetaClient.GetItemProcessingResultsApiV1BetaBatchProcessingItemsItemIdProcessingResultsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Item Processing Results<br/>
        /// Get all processing results for a specific item.<br/>
        /// Returns the complete processing history for an item including<br/>
        /// what operations were performed, parameters used, and where<br/>
        /// outputs are stored. Optionally filter by `job_type`.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="jobType">
        /// Filter results by job type
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ItemProcessingResultsResponse> GetItemProcessingResultsApiV1BetaBatchProcessingItemsItemIdProcessingResultsGetAsync(
            string itemId,
            global::G.BatchJobType? jobType = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}