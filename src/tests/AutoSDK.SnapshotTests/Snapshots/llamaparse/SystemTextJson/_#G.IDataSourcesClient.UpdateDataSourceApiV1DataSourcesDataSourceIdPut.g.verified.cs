//HintName: G.IDataSourcesClient.UpdateDataSourceApiV1DataSourcesDataSourceIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Update Data Source<br/>
        /// Update a data source by ID.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> UpdateDataSourceApiV1DataSourcesDataSourceIdPutAsync(
            global::System.Guid dataSourceId,

            global::G.DataSourceUpdate request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Data Source<br/>
        /// Update a data source by ID.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// The name of the data source.
        /// </param>
        /// <param name="sourceType"></param>
        /// <param name="customMetadata">
        /// Custom metadata that will be present on all data loaded from the data source
        /// </param>
        /// <param name="component">
        /// Component that implements the data source
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> UpdateDataSourceApiV1DataSourcesDataSourceIdPutAsync(
            global::System.Guid dataSourceId,
            global::G.ConfigurableDataSourceNames sourceType,
            string? session = default,
            string? name = default,
            object? customMetadata = default,
            global::G.AnyOf<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource, object>? component = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}