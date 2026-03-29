//HintName: G.IRunsClient.ListStepsForRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Steps For Run<br/>
        /// Get steps associated with a run with filtering options.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="before">
        /// Cursor for pagination
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Maximum number of messages to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for steps by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Step>> ListStepsForRunAsync(
            string runId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListStepsForRunOrder? order = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}