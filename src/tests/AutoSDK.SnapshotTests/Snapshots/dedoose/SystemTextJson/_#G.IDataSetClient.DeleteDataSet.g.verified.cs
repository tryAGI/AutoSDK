//HintName: G.IDataSetClient.DeleteDataSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
    {
        /// <summary>
        /// DeleteDataSet<br/>
        /// DeleteDataSet
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DeleteDataSetAsync(

            global::G.DeleteDataSetRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// DeleteDataSet<br/>
        /// DeleteDataSet
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DeleteDataSetAsync(
            global::G.DataSetVO dataSet,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}