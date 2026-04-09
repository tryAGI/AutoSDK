//HintName: G.IExperimentClient.UpdateExperimentTableRow.g.cs
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateExperimentTableRowAsync(
            string experimentId,

            global::G.UpdateExperimentTableRowRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="inputRecordId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateExperimentTableRowAsync(
            string experimentId,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string inputRecordId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}