//HintName: G.IJobsClient.ListActiveJobs.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List Active Jobs<br/>
        /// List all active jobs.
        /// </summary>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` parameter instead. Only list jobs associated with the source.
        /// </param>
        /// <param name="before">
        /// Cursor for pagination
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Limit for pagination<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="ascending">
        /// Whether to sort jobs oldest to newest (True, default) or newest to oldest (False)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Job>> ListActiveJobsAsync(
            string? sourceId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            bool? ascending = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}