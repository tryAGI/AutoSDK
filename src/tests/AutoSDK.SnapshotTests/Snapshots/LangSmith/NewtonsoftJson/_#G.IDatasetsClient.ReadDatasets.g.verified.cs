//HintName: G.IDatasetsClient.ReadDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Datasets<br/>
        /// Get all datasets by query params and owner.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
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
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Dataset>> ReadDatasetsAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?>? dataType = default,
            string? name = default,
            string? nameContains = default,
            string? metadata = default,
            int? offset = default,
            int? limit = default,
            global::G.SortByDatasetColumn? sortBy = default,
            bool? sortByDesc = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}