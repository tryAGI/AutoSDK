//HintName: G.IDataSourcesClient.GetDataSourceApiV1DataSourcesDataSourceIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Get Data Source<br/>
        /// Get a data source by ID.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> GetDataSourceApiV1DataSourcesDataSourceIdGetAsync(
            global::System.Guid dataSourceId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}