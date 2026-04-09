//HintName: G.IApi.FileSearchStoresDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes a `FileSearchStore`.
        /// </summary>
        /// <param name="force"></param>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> FileSearchStoresDeleteAsync(
            string fileSearchStoresId,
            bool? force = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}