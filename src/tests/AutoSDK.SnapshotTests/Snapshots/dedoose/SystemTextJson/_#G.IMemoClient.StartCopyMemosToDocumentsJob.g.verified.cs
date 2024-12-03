//HintName: G.IMemoClient.StartCopyMemosToDocumentsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartCopyMemosToDocumentsJob<br/>
        /// StartCopyMemosToDocumentsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartCopyMemosToDocumentsJobAsync(
            global::G.StartCopyMemosToDocumentsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartCopyMemosToDocumentsJob<br/>
        /// StartCopyMemosToDocumentsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="memoIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartCopyMemosToDocumentsJobAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}