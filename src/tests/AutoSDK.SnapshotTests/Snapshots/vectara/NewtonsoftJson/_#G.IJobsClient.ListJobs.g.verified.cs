//HintName: G.IJobsClient.ListJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List jobs<br/>
        /// List jobs for the account. Jobs are background processes like replacing the filterable metadata attributes.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey"></param>
        /// <param name="after"></param>
        /// <param name="state"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListJobsResponse> ListJobsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.IList<string>? corpusKey = default,
            global::System.DateTime? after = default,
            global::System.Collections.Generic.IList<global::G.JobState>? state = default,
            int? limit = 10,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}