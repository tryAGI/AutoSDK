//HintName: G.ISourcesClient.DeleteFileFromSource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Delete File From Source<br/>
        /// Delete a data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="fileId">
        /// The ID of the file in the format 'file-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task DeleteFileFromSourceAsync(
            string sourceId,
            string fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}