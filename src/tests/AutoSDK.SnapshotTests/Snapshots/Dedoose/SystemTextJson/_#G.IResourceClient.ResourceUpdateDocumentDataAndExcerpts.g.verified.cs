//HintName: G.IResourceClient.ResourceUpdateDocumentDataAndExcerpts.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// UpdateDocumentDataAndExcerpts.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceUpdateDocumentDataAndExcerptsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Guid? resourceId = default,
            string? updatedTextDataURI = default,
            int? updatedLength = default,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}