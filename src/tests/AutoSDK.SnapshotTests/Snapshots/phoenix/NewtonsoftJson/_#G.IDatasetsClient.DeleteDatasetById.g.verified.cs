//HintName: G.IDatasetsClient.DeleteDatasetById.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete dataset by ID
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset to delete.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}