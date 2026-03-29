//HintName: G.IApi.FileSearchStoresDocumentsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific `Document`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="documentsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Document> FileSearchStoresDocumentsGetAsync(
            string fileSearchStoresId,
            string documentsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}