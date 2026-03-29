//HintName: G.IApi.FileSearchStoresDocumentsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes a `Document`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="force"></param>
        /// <param name="documentsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> FileSearchStoresDocumentsDeleteAsync(
            string fileSearchStoresId,
            string documentsId,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}