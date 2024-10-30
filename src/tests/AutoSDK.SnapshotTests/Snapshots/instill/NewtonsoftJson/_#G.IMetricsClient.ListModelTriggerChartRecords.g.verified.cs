//HintName: G.IMetricsClient.ListModelTriggerChartRecords.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// List model trigger time charts<br/>
        /// Returns a timeline of model trigger counts for a given requester. The<br/>
        /// response will contain one set of records (datapoints), representing the<br/>
        /// amount of triggers in a time bucket.
        /// </summary>
        /// <param name="requesterId"></param>
        /// <param name="aggregationWindow"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelTriggerChartRecordsResponse> ListModelTriggerChartRecordsAsync(
            string requesterId,
            string? aggregationWindow = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}