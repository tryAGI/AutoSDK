//HintName: G.IDatasetsClient.DeleteDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}