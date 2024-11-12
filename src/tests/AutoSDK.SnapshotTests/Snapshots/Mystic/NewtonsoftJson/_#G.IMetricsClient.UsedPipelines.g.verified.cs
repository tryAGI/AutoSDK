//HintName: G.IMetricsClient.UsedPipelines.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Used Pipelines<br/>
        /// Retrieve paginated metrics for all pipelines used by a user, optionally<br/>
        /// filtered by 'search'.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedPipelineMetrics> UsedPipelinesAsync(
            string? search = default,
            int? skip = default,
            int? limit = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}