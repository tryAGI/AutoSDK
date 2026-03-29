//HintName: G.IDatasetsClient.ListDatasetVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Dataset Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DatasetResponse>> ListDatasetVersionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}