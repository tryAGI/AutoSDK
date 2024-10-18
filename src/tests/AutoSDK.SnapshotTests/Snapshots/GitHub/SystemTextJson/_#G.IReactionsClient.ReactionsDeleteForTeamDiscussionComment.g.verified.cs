//HintName: G.IReactionsClient.ReactionsDeleteForTeamDiscussionComment.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Delete team discussion comment reaction<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team or organization with `team_id` and `org_id` using the route `DELETE /organizations/:org_id/team/:team_id/discussions/:discussion_number/comments/:comment_number/reactions/:reaction_id`.<br/>
        /// Delete a reaction to a [team discussion comment](https://docs.github.com/rest/teams/discussion-comments#get-a-discussion-comment).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="reactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReactionsDeleteForTeamDiscussionCommentAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            int commentNumber,
            int reactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}