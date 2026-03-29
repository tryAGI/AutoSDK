//HintName: G.IDataSourcesClient.UpdateConnector.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Update a connector<br/>
        /// Update a connector.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update a connector for.<br/>
        ///     connector_id: The ID of the connector to update.<br/>
        ///     params: The connector to update.<br/>
        /// Returns:<br/>
        ///     The updated connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update a connector for
        /// </param>
        /// <param name="connectorId">
        /// The ID of the connector to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnector> UpdateConnectorAsync(
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,

            global::G.DataSourceConnectorUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connector<br/>
        /// Update a connector.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update a connector for.<br/>
        ///     connector_id: The ID of the connector to update.<br/>
        ///     params: The connector to update.<br/>
        /// Returns:<br/>
        ///     The updated connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update a connector for
        /// </param>
        /// <param name="connectorId">
        /// The ID of the connector to update
        /// </param>
        /// <param name="name">
        /// The name of the connector
        /// </param>
        /// <param name="metadata">
        /// The metadata of the connector
        /// </param>
        /// <param name="triggerSync">
        /// Whether the connector should be synced after update
        /// </param>
        /// <param name="pollingInterval">
        /// Polling interval for the connector. Defaults to 30 minutes if not specified. Can be provided as:<br/>
        /// - int: Number of seconds (e.g., 1800 for 30 minutes)<br/>
        /// - str: Duration string (e.g., '30m', '1h', '2d') or ISO 8601 format (e.g., 'PT30M', 'P1D')<br/>
        /// Valid range: 15 seconds to 30 days
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnector> UpdateConnectorAsync(
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,
            string? name = default,
            object? metadata = default,
            bool? triggerSync = default,
            global::G.AnyOf<int?, string, object>? pollingInterval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}