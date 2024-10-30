//HintName: G.IMetricsClient.ListPipelineTriggerChartRecords.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// List pipeline trigger time charts<br/>
        /// Returns a timeline of pipline trigger counts for the pipelines of a given<br/>
        /// owner.<br/>
        /// NOTE: This method will soon return the trigger counts of a given requester.
        /// </summary>
        /// <param name="aggregationWindow"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPipelineTriggerChartRecordsResponse> ListPipelineTriggerChartRecordsAsync(
            int? aggregationWindow = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}