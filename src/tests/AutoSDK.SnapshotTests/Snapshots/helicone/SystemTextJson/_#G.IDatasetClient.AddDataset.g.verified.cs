//HintName: G.IDatasetClient.AddDataset.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultDatasetIdStringString> AddDatasetAsync(

            global::G.NewDatasetParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="requestIds"></param>
        /// <param name="datasetType"></param>
        /// <param name="meta"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultDatasetIdStringString> AddDatasetAsync(
            string datasetName,
            global::System.Collections.Generic.IList<string> requestIds,
            global::G.NewDatasetParamsDatasetType datasetType,
            global::G.DatasetMetadata? meta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}