//HintName: G.IExperimentClient.CreateExperimentColumn.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentColumnAsync(
            string experimentTableId,

            global::G.CreateExperimentColumnRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="inputKeys"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="hypothesisId"></param>
        /// <param name="columnType"></param>
        /// <param name="columnName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentColumnAsync(
            string experimentTableId,
            string columnType,
            string columnName,
            global::System.Collections.Generic.IList<string>? inputKeys = default,
            string? promptVersionId = default,
            string? hypothesisId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}