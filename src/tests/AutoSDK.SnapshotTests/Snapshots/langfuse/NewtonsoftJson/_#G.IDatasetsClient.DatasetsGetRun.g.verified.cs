//HintName: G.IDatasetsClient.DatasetsGetRun.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset run and its items
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="runName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetRunWithItems> DatasetsGetRunAsync(
            string datasetName,
            string runName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}