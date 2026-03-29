//HintName: G.IDocumentsClient.ListDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentsClient
    {
        /// <summary>
        /// List Documents<br/>
        /// Retrieve a list of documents with optional filtering and pagination.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDocumentsResponse> ListDocumentsAsync(
            int? page = default,
            int? pageSize = default,
            string? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}