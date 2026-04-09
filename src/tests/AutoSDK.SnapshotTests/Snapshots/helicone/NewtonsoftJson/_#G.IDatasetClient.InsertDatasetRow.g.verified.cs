//HintName: G.IDatasetClient.InsertDatasetRow.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> InsertDatasetRowAsync(
            string datasetId,

            global::G.InsertDatasetRowRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="originalColumnId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="inputRecordId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> InsertDatasetRowAsync(
            string datasetId,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string inputRecordId,
            string? originalColumnId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}