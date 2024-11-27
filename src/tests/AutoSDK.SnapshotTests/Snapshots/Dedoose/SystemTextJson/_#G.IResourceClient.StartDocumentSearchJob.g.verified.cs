//HintName: G.IResourceClient.StartDocumentSearchJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartDocumentSearchJob<br/>
        /// StartDocumentSearchJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartDocumentSearchJobAsync(
            global::G.StartDocumentSearchJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartDocumentSearchJob<br/>
        /// StartDocumentSearchJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartDocumentSearchJobAsync(
            global::System.Guid projectId,
            string searchText,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}