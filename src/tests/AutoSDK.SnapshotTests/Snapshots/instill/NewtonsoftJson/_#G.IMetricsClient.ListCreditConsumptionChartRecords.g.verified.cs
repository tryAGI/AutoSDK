//HintName: G.IMetricsClient.ListCreditConsumptionChartRecords.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// List Instill Credit consumption time charts<br/>
        /// Returns a timeline of Instill Credit consumption for a given owner. The<br/>
        /// response will contain one set of records (datapoints) per consumption<br/>
        /// source (e.g. "pipeline", "model"). Each datapoint represents the amount<br/>
        /// consumed in a time bucket.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="aggregationWindow"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListCreditConsumptionChartRecordsResponse> ListCreditConsumptionChartRecordsAsync(
            string namespaceId,
            string? aggregationWindow = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}