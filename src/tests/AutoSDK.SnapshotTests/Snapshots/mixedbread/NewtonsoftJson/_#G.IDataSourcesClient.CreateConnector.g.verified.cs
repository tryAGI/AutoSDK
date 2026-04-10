//HintName: G.IDataSourcesClient.CreateConnector.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Create a new connector<br/>
        /// Create a new connector.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to create a connector for.<br/>
        ///     params: The connector to create.<br/>
        /// Returns:<br/>
        ///     The created connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to create a connector for
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnector> CreateConnectorAsync(
            global::System.Guid dataSourceId,

            global::G.DataSourceConnectorCreateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new connector<br/>
        /// Create a new connector.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to create a connector for.<br/>
        ///     params: The connector to create.<br/>
        /// Returns:<br/>
        ///     The created connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to create a connector for
        /// </param>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="name">
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </param>
        /// <param name="triggerSync">
        /// Whether the connector should be synced after creation<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// The metadata of the connector
        /// </param>
        /// <param name="pollingInterval">
        /// Polling interval for the connector. Defaults to 30 minutes if not specified. Can be provided as:<br/>
        /// - int: Number of seconds (e.g., 1800 for 30 minutes)<br/>
        /// - str: Duration string (e.g., '30m', '1h', '2d') or ISO 8601 format (e.g., 'PT30M', 'P1D')<br/>
        /// Valid range: 15 seconds to 30 days
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnector> CreateConnectorAsync(
            global::System.Guid dataSourceId,
            string storeId,
            string? name = default,
            bool? triggerSync = default,
            object? metadata = default,
            global::G.AnyOf<int?, string, object>? pollingInterval = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}