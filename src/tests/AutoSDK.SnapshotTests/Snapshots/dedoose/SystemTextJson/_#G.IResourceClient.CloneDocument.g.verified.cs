//HintName: G.IResourceClient.CloneDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// CloneDocument<br/>
        /// CloneDocument
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneDocumentResponse> CloneDocumentAsync(

            global::G.CloneDocumentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// CloneDocument<br/>
        /// CloneDocument
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cloneExcerpts"></param>
        /// <param name="cloneTagApps"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneDocumentResponse> CloneDocumentAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool cloneExcerpts,
            bool cloneTagApps,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}