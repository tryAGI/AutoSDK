//HintName: G.IDatasetsClient.DeleteDatasetId.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete dataset<br/>
        /// Delete a dataset object by its id
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> DeleteDatasetIdAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}