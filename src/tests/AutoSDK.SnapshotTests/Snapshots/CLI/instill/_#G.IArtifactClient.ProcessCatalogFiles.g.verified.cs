//HintName: G.IArtifactClient.ProcessCatalogFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Process catalog files<br/>
        /// Processes catalog files.
        /// </summary>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(

            global::G.ProcessCatalogFilesRequest request,
            string? instillRequesterUid = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process catalog files<br/>
        /// Processes catalog files.
        /// </summary>
        /// <param name="instillRequesterUid"></param>
        /// <param name="fileUids">
        /// The file uid.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::System.Collections.Generic.IList<string> fileUids,
            string? instillRequesterUid = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}