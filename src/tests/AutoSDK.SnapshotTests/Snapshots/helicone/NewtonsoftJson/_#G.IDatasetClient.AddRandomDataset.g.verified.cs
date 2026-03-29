//HintName: G.IDatasetClient.AddRandomDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultDatasetIdStringString> AddRandomDatasetAsync(

            global::G.RandomDatasetParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultDatasetIdStringString> AddRandomDatasetAsync(
            string datasetName,
            global::G.DatasetFilterNode filter,
            double? offset = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}