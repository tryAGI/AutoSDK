//HintName: G.IExperimentClient.CreateExperimentTableRowWithCellsBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentTableRowWithCellsBatchAsync(
            string experimentTableId,

            global::G.CreateExperimentTableRowWithCellsBatchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="rows"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentTableRowWithCellsBatchAsync(
            string experimentTableId,
            global::System.Collections.Generic.IList<global::G.CreateExperimentTableRowWithCellsBatchRequestRow> rows,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}