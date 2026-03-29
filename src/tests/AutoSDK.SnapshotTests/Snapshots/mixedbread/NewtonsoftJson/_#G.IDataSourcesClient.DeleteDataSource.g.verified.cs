//HintName: G.IDataSourcesClient.DeleteDataSource.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Delete a data source<br/>
        /// Delete a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to delete.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSourceDeleted> DeleteDataSourceAsync(
            global::System.Guid dataSourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}