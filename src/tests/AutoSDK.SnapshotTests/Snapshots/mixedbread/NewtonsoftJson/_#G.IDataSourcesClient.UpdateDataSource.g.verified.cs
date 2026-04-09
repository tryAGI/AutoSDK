//HintName: G.IDataSourcesClient.UpdateDataSource.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSourcesClient
    {
        /// <summary>
        /// Update a data source<br/>
        /// Update a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update.<br/>
        ///     params: The data source to update.<br/>
        /// Returns:<br/>
        ///     The updated data source.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> UpdateDataSourceAsync(
            global::System.Guid dataSourceId,

            global::G.AnyOf<global::G.NotionDataSourceCreateOrUpdateParams, global::G.LinearDataSourceCreateOrUpdateParams> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a data source<br/>
        /// Update a data source.<br/>
        /// Args:<br/>
        ///     data_source_id: The ID of the data source to update.<br/>
        ///     params: The data source to update.<br/>
        /// Returns:<br/>
        ///     The updated data source.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source to update
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSource> UpdateDataSourceAsync(
            global::System.Guid dataSourceId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}