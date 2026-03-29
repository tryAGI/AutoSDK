//HintName: G.IDataSourcesClient.DeleteConnector.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Delete a connector<br/>
        /// Delete a connector.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to delete a connector for.<br/>
        ///     connector_id: The ID of the connector to delete.<br/>
        /// Returns:<br/>
        ///     The deleted connector.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to delete a connector for
        /// </param>
        /// <param name="connectorId">
        /// The ID of the connector to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceConnectorDeleted> DeleteConnectorAsync(
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}