//HintName: G.ITranslateDocumentsClient.DownloadDocument.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslateDocumentsClient
    {
        /// <summary>
        /// Download Translated Document<br/>
        /// Once the status of the document translation process is `done`, the result can be downloaded.<br/>
        /// For privacy reasons the translated document is automatically removed from the server once it was downloaded and cannot be downloaded again.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(
            string documentId,

            global::G.DocumentKey request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Translated Document<br/>
        /// Once the status of the document translation process is `done`, the result can be downloaded.<br/>
        /// For privacy reasons the translated document is automatically removed from the server once it was downloaded and cannot be downloaded again.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentKey1">
        /// The document encryption key that was sent to the client when the document was uploaded to the API.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadDocumentAsync(
            string documentId,
            string documentKey1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}