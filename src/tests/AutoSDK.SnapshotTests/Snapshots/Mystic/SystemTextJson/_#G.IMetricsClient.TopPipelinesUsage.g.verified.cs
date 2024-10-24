//HintName: G.IMetricsClient.TopPipelinesUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Top Pipelines Usage<br/>
        /// Retrieve usage metrics for top 'num_pipelines' (in terms of number of<br/>
        /// runs) for the provided time period.
        /// </summary>
        /// <param name="numPipelines">
        /// Default Value: 20
        /// </param>
        /// <param name="clusterId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="intervalUnit">
        /// An enumeration.
        /// </param>
        /// <param name="intervalValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TopPipelinesUsageAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue,
            int? numPipelines = default,
            string? clusterId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}