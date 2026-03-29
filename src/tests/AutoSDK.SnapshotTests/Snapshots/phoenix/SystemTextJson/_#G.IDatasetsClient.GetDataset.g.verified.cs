//HintName: G.IDatasetsClient.GetDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset by ID
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDatasetResponseBody> GetDatasetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}