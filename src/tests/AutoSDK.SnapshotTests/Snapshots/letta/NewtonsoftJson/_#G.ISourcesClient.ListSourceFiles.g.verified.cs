//HintName: G.ISourcesClient.ListSourceFiles.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// List Source Files<br/>
        /// List paginated files associated with a data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="limit">
        /// Number of files to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="after">
        /// Pagination cursor to fetch the next set of results
        /// </param>
        /// <param name="includeContent">
        /// Whether to include full file content<br/>
        /// Default Value: false
        /// </param>
        /// <param name="checkStatusUpdates">
        /// Whether to check and update file processing status (from the vector db service). If False, will not fetch and update the status, which may lead to performance gains.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FileMetadata>> ListSourceFilesAsync(
            string sourceId,
            int? limit = default,
            string? after = default,
            bool? includeContent = default,
            bool? checkStatusUpdates = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}