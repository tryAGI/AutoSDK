//HintName: G.IDatasetsClient.GetDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="includeDatapoints"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetResponse> GetDatasetAsync(
            string id,
            string? versionId = default,
            bool? includeDatapoints = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}