//HintName: G.IExperimentsClient.FindExperimentGroupsAggregations.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Find experiment groups with aggregations<br/>
        /// Find experiments grouped by specified fields with aggregation metrics
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="types"></param>
        /// <param name="name">
        /// Filter experiments by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="projectDeleted">
        /// Filter experiments by deleted projects
        /// </param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExperimentGroupAggregationsResponse> FindExperimentGroupsAggregationsAsync(
            string? groups = default,
            string? types = default,
            string? name = default,
            global::System.Guid? projectId = default,
            bool? projectDeleted = default,
            string? filters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}