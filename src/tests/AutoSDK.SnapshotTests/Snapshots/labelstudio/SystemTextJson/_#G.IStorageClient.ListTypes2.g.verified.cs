//HintName: G.IStorageClient.ListTypes2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all import storages types<br/>
        /// Retrieve a list of the import storages types.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiStoragesTypesRetrieveResponseItem>> ListTypes2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}