//HintName: G.IDataSourcesClient.ListDataSources.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Get all data sources<br/>
        /// Get all data sources.<br/>
        /// Returns:<br/>
        ///     The list of data sources.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceListResponse> ListDataSourcesAsync(
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}