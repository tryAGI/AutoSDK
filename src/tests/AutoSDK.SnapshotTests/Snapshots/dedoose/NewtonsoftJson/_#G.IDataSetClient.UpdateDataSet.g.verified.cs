//HintName: G.IDataSetClient.UpdateDataSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
    {
        /// <summary>
        /// UpdateDataSet<br/>
        /// UpdateDataSet
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> UpdateDataSetAsync(

            global::G.UpdateDataSetRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// UpdateDataSet<br/>
        /// UpdateDataSet
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> UpdateDataSetAsync(
            global::G.DataSetVO dataSet,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}