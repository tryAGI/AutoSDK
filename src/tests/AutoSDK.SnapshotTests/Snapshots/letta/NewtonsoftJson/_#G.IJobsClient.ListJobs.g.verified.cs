//HintName: G.IJobsClient.ListJobs.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List Jobs<br/>
        /// List all jobs.
        /// </summary>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` parameter instead. Only list jobs associated with the source.
        /// </param>
        /// <param name="before">
        /// Job ID cursor for pagination. Returns jobs that come before this job ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Job ID cursor for pagination. Returns jobs that come after this job ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of jobs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for jobs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="active">
        /// Filter for active jobs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ascending">
        /// Whether to sort jobs oldest to newest (True, default) or newest to oldest (False). Deprecated in favor of order field.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Job>> ListJobsAsync(
            string? sourceId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListJobsOrder? order = default,
            string? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}