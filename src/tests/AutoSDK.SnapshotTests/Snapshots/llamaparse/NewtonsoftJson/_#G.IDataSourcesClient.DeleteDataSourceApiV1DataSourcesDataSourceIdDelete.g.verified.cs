//HintName: G.IDataSourcesClient.DeleteDataSourceApiV1DataSourcesDataSourceIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Delete Data Source<br/>
        /// Delete a data source by ID.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDataSourceApiV1DataSourcesDataSourceIdDeleteAsync(
            global::System.Guid dataSourceId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}