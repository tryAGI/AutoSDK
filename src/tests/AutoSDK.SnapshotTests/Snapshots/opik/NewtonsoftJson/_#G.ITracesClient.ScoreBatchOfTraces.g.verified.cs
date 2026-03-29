//HintName: G.ITracesClient.ScoreBatchOfTraces.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Batch feedback scoring for traces<br/>
        /// Batch feedback scoring for traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfTracesAsync(

            global::G.FeedbackScoreBatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch feedback scoring for traces<br/>
        /// Batch feedback scoring for traces
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfTracesAsync(
            global::System.Collections.Generic.IList<global::G.FeedbackScoreBatchItem> scores,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}