//HintName: G.IBulkExportsClient.CreateBulkExportDestination.g.cs
#nullable enable

namespace G
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Create Bulk Export Destination<br/>
        /// Create a new bulk export destination
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExportDestination> CreateBulkExportDestinationAsync(

            global::G.BulkExportDestinationCreate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Bulk Export Destination<br/>
        /// Create a new bulk export destination
        /// </summary>
        /// <param name="destinationType">
        /// Default Value: s3
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="config"></param>
        /// <param name="credentials"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkExportDestination> CreateBulkExportDestinationAsync(
            string displayName,
            global::G.BulkExportDestinationS3Config config,
            global::G.BulkExportDestinationS3Credentials credentials,
            global::G.BulkExportDestinationType? destinationType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}