//HintName: G.IMetricsClient.OverallUsageSummary.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Overall Usage Summary
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OverallUsageSummary> OverallUsageSummaryAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}