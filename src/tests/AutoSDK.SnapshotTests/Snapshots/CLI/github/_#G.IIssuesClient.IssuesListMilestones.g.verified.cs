﻿//HintName: G.IIssuesClient.IssuesListMilestones.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List milestones<br/>
        /// Lists milestones for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="sort">
        /// Default Value: due_on
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Milestone>> IssuesListMilestonesAsync(
            string owner,
            string repo,
            global::G.IssuesListMilestonesState? state = default,
            global::G.IssuesListMilestonesSort? sort = default,
            global::G.IssuesListMilestonesDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}