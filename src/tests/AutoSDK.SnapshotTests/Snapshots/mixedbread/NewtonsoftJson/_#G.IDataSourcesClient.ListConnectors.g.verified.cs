//HintName: G.IDataSourcesClient.ListConnectors.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Get all connectors for a data source<br/>
        /// Get all connectors for a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to get connectors for.<br/>
        ///     pagination: The pagination options.<br/>
        /// Returns:<br/>
        ///     The list of connectors.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to get connectors for
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ConnectorListResponse> ListConnectorsAsync(
            global::System.Guid dataSourceId,
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}