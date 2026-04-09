//HintName: G.IDataSourcesClient.GetConnector.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Get a connector by ID<br/>
        /// Get a connector by ID.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to get a connector for.<br/>
        ///     connector_id: The ID of the connector to get.<br/>
        /// Returns:<br/>
        ///     The connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to get a connector for
        /// </param>
        /// <param name="connectorId">
        /// The ID of the connector to get
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnector> GetConnectorAsync(
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}