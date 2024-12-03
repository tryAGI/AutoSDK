//HintName: G.IReactionsClient.ReactionsCreateForTeamDiscussionInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Create reaction for a team discussion<br/>
        /// Create a reaction to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create reaction for a team discussion<br/>
        /// Create a reaction to a [team discussion](https://docs.github.com/rest/teams/discussions#get-a-discussion).<br/>
        /// A response with an HTTP `200` status means that you already added the reaction type to this team discussion.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `POST /organizations/:org_id/team/:team_id/discussions/:discussion_number/reactions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForTeamDiscussionInOrgAsync(
            string org,
            string teamSlug,
            int discussionNumber,
            global::G.ReactionsCreateForTeamDiscussionInOrgRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}