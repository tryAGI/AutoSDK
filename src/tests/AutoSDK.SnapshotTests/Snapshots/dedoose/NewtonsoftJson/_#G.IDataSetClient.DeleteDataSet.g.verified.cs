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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DeleteDataSetAsync(
            global::G.DeleteDataSetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteDataSet<br/>
        /// DeleteDataSet
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DeleteDataSetAsync(
            global::G.DataSetVO dataSet,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}