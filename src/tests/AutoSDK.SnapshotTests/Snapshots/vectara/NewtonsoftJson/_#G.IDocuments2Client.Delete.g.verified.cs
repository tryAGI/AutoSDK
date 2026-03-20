//HintName: G.IDocuments2Client.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IDocuments2Client
    {
        /// <summary>
        /// Delete a document<br/>
        /// Permanently delete a document identified by its unique `document_id` from a specific corpus. This operation cannot be undone, so use it with caution.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string corpusKey,
            string documentId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}