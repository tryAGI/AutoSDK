//HintName: G.ISourcesClient.UploadFileToSource.g.cs
#nullable enable

namespace G
{
    public partial interface ISourcesClient
    {
        /// <summary>
        /// Upload File To Source<br/>
        /// Upload a file to a data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToSourceAsync(
            string sourceId,

            global::G.BodyUploadFileToSource request,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File To Source<br/>
        /// Upload a file to a data source.
        /// </summary>
        /// <param name="sourceId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="duplicateHandling">
        /// How to handle duplicate filenames<br/>
        /// Default Value: suffix
        /// </param>
        /// <param name="name">
        /// Optional custom name to override the uploaded file's name
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.FileMetadata> UploadFileToSourceAsync(
            string sourceId,
            byte[] file,
            string filename,
            global::G.DuplicateFileHandling? duplicateHandling = default,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}