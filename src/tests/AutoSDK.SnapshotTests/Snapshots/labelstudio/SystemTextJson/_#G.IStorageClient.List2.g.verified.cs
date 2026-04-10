//HintName: G.IStorageClient.List2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// List all export storages from the project<br/>
        /// Retrieve a list of the export storages of all types with their IDs.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> List2Async(
            string? ordering = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}