//HintName: G.IDataSourcesClient.GetDataSource.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Get a data source by ID<br/>
        /// Get a data source by ID.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to fetch.<br/>
        /// Returns:<br/>
        ///     The data source.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to fetch
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> GetDataSourceAsync(
            global::System.Guid dataSourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}