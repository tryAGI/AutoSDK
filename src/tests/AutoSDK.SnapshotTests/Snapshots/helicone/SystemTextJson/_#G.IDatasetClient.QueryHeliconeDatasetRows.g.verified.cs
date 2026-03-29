//HintName: G.IDatasetClient.QueryHeliconeDatasetRows.g.cs
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeDatasetRowArrayString> QueryHeliconeDatasetRowsAsync(
            string datasetId,

            global::G.QueryHeliconeDatasetRowsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeDatasetRowArrayString> QueryHeliconeDatasetRowsAsync(
            string datasetId,
            double limit,
            double offset,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}