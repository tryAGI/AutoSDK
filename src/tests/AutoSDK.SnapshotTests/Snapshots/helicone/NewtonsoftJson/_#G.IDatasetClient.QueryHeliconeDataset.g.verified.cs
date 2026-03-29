//HintName: G.IDatasetClient.QueryHeliconeDataset.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeDatasetArrayString> QueryHeliconeDatasetAsync(

            global::G.QueryHeliconeDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHeliconeDatasetArrayString> QueryHeliconeDatasetAsync(
            global::System.Collections.Generic.IList<string>? datasetIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}