//HintName: G.IIssuesClient.IssuesGetEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Get an issue event<br/>
        /// Gets a single event by the event id.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IssueEvent> IssuesGetEventAsync(
            string owner,
            string repo,
            int eventId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}