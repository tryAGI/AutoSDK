//HintName: G.IReactionsClient.ReactionsDeleteForTeamDiscussion.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Delete team discussion reaction<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team or organization with `team_id` and `org_id` using the route `DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions/:reaction_id`.<br/>
        /// Delete a reaction to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="reactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReactionsDeleteForTeamDiscussionAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            int reactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}