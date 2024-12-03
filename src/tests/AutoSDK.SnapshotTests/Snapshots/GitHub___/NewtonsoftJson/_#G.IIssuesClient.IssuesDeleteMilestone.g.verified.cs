//HintName: G.IIssuesClient.IssuesDeleteMilestone.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Delete a milestone<br/>
        /// Deletes a milestone using the given milestone number.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task IssuesDeleteMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}