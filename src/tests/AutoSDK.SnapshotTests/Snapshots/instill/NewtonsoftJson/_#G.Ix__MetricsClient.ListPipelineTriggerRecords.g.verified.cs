//HintName: G.Ix__MetricsClient.ListPipelineTriggerRecords.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__MetricsClient
    {
        /// <summary>
        /// List pipeline triggers<br/>
        /// Returns a paginated list of pipeline executions.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPipelineTriggerRecordsResponse> ListPipelineTriggerRecordsAsync(
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}