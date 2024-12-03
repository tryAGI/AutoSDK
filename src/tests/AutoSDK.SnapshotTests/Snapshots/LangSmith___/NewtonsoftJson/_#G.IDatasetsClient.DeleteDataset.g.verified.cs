//HintName: G.IDatasetsClient.DeleteDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Dataset<br/>
        /// Delete a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDatasetAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}