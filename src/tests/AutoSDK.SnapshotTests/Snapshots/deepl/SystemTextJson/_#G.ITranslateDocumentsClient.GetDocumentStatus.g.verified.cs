//HintName: G.ITranslateDocumentsClient.GetDocumentStatus.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslateDocumentsClient
    {
        /// <summary>
        /// Check Document Status<br/>
        /// Retrieve the current status of a document translation process.<br/>
        /// If the translation is still in progress, the estimated time remaining is also included in the response.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDocumentStatusResponse> GetDocumentStatusAsync(
            string documentId,

            global::G.DocumentKey request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Document Status<br/>
        /// Retrieve the current status of a document translation process.<br/>
        /// If the translation is still in progress, the estimated time remaining is also included in the response.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.GetDocumentStatusResponse>> GetDocumentStatusAsResponseAsync(
            string documentId,

            global::G.DocumentKey request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Document Status<br/>
        /// Retrieve the current status of a document translation process.<br/>
        /// If the translation is still in progress, the estimated time remaining is also included in the response.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="documentKey1">
        /// The document encryption key that was sent to the client when the document was uploaded to the API.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDocumentStatusResponse> GetDocumentStatusAsync(
            string documentId,
            string documentKey1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}