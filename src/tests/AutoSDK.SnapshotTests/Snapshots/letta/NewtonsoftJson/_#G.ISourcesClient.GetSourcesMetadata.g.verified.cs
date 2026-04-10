//HintName: G.ISourcesClient.GetSourcesMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Get Sources Metadata<br/>
        /// Get aggregated metadata for all sources in an organization.<br/>
        /// Returns structured metadata including:<br/>
        /// - Total number of sources<br/>
        /// - Total number of files across all sources<br/>
        /// - Total size of all files<br/>
        /// - Per-source breakdown with file details (file_name, file_size per file) if include_detailed_per_source_metadata is True
        /// </summary>
        /// <param name="includeDetailedPerSourceMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.OrganizationSourcesStats> GetSourcesMetadataAsync(
            bool? includeDetailedPerSourceMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}