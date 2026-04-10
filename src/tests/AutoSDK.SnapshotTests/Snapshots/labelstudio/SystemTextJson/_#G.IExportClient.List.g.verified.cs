//HintName: G.IExportClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// List all export snapshots<br/>
        /// Returns a list of exported files for a specific project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Export>> ListAsync(
            int id,
            string? ordering = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}