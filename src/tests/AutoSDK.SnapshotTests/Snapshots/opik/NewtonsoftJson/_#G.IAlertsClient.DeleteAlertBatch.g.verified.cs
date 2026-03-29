//HintName: G.IAlertsClient.DeleteAlertBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Delete alert batch<br/>
        /// Delete multiple alerts by their IDs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAlertBatchAsync(

            global::G.BatchDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete alert batch<br/>
        /// Delete multiple alerts by their IDs
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteAlertBatchAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}