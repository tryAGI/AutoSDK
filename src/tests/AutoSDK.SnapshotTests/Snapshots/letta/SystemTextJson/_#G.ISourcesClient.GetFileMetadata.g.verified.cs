//HintName: G.ISourcesClient.GetFileMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Get File Metadata<br/>
        /// Retrieve metadata for a specific file by its ID.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="fileId">
        /// The ID of the file in the format 'file-&lt;uuid4&gt;'
        /// </param>
        /// <param name="includeContent">
        /// Whether to include full file content<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.FileMetadata> GetFileMetadataAsync(
            string sourceId,
            string fileId,
            bool? includeContent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}