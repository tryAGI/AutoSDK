//HintName: G.IDatasetsClient.ReadDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Dataset<br/>
        /// Get a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> ReadDatasetAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}