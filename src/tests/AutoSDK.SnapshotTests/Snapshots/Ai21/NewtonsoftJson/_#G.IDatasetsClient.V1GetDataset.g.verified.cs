//HintName: G.IDatasetsClient.V1GetDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Get
        /// </summary>
        /// <param name="datasetPid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1GetDatasetAsync(
            string datasetPid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}