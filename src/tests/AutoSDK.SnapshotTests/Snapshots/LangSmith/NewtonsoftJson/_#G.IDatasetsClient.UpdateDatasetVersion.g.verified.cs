//HintName: G.IDatasetsClient.UpdateDatasetVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,
            global::G.PutDatasetVersionsSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersion> UpdateDatasetVersionAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<global::System.DateTime?, string> asOf,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}