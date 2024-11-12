//HintName: G.IPublicClient.ReadSharedDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Dataset<br/>
        /// Get dataset by ids or the shared dataset if not specifed.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Enum for available dataset columns to sort by.
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetPublicSchema> ReadSharedDatasetAsync(
            global::System.Guid shareToken,
            int? offset = default,
            int? limit = default,
            global::G.SortByDatasetColumn? sortBy = default,
            bool? sortByDesc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}