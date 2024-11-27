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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneDocumentResponse> CloneDocumentAsync(
            global::G.CloneDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// CloneDocument<br/>
        /// CloneDocument
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cloneExcerpts"></param>
        /// <param name="cloneTagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloneDocumentResponse> CloneDocumentAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool cloneExcerpts,
            bool cloneTagApps,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}