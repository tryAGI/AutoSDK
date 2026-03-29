//HintName: G.ITracesClient.BatchUpdateThreads.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Batch update threads<br/>
        /// Update multiple threads
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateThreadsAsync(

            global::G.TraceThreadBatchUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update threads<br/>
        /// Update multiple threads
        /// </summary>
        /// <param name="ids">
        /// List of thread model IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateThreadsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.TraceThreadUpdate update,
            bool? mergeTags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}