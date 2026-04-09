//HintName: G.IDocumentStoreClient.RefreshDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Re-process and upsert all documents in document store<br/>
        /// Re-process and upsert all existing documents in document store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.VectorUpsertResponse>> RefreshDocumentAsync(
            global::System.Guid id,

            global::G.DocumentStoreLoaderForRefresh request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Re-process and upsert all documents in document store<br/>
        /// Re-process and upsert all existing documents in document store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="items"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.VectorUpsertResponse>> RefreshDocumentAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::G.DocumentStoreLoaderForUpsert>? items = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}