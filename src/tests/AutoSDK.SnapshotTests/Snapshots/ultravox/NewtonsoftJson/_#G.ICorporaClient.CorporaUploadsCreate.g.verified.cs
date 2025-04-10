//HintName: G.ICorporaClient.CorporaUploadsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Request a presigned URL for uploading a document.
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CorpusUploadsResponse> CorporaUploadsCreateAsync(
            global::System.Guid corpusId,
            global::G.CorpusUploadsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request a presigned URL for uploading a document.
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="mimeType">
        /// The MIME type of the file to be uploaded.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CorpusUploadsResponse> CorporaUploadsCreateAsync(
            global::System.Guid corpusId,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}