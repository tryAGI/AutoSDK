//HintName: G.IIssuesClient.IssuesCreateMilestone.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Create a milestone<br/>
        /// Creates a milestone.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Milestone> IssuesCreateMilestoneAsync(
            string owner,
            string repo,
            global::G.IssuesCreateMilestoneRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a milestone<br/>
        /// Creates a milestone.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="title">
        /// The title of the milestone.
        /// </param>
        /// <param name="state">
        /// The state of the milestone. Either `open` or `closed`.<br/>
        /// Default Value: open
        /// </param>
        /// <param name="description">
        /// A description of the milestone.
        /// </param>
        /// <param name="dueOn">
        /// The milestone due date. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Milestone> IssuesCreateMilestoneAsync(
            string owner,
            string repo,
            string title,
            global::G.IssuesCreateMilestoneRequestState? state = default,
            string? description = default,
            global::System.DateTime? dueOn = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}