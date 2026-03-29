//HintName: G.IExperimentClient.DeleteExperimentTableRows.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> DeleteExperimentTableRowsAsync(
            string experimentId,

            global::G.DeleteExperimentTableRowsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="inputRecordIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> DeleteExperimentTableRowsAsync(
            string experimentId,
            global::System.Collections.Generic.IList<string> inputRecordIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}