//HintName: G.IResourceClient.UpdateDocumentDataAndExcerpts.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateDocumentDataAndExcerpts<br/>
        /// UpdateDocumentDataAndExcerpts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDocumentDataAndExcerptsAsync(

            global::G.UpdateDocumentDataAndExcerptsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// UpdateDocumentDataAndExcerpts<br/>
        /// UpdateDocumentDataAndExcerpts
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDocumentDataAndExcerptsAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            string updatedTextDataURI,
            int updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt> excerpts,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}