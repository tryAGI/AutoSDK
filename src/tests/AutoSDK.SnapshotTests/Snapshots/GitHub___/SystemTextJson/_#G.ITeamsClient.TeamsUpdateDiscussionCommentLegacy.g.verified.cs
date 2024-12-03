//HintName: G.ITeamsClient.TeamsUpdateDiscussionCommentLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a discussion comment (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion comment](https://docs.github.com/rest/teams/discussion-comments#update-a-discussion-comment) endpoint.<br/>
        /// Edits the body text of a discussion comment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamDiscussionComment> TeamsUpdateDiscussionCommentLegacyAsync(
            int teamId,
            int discussionNumber,
            int commentNumber,
            global::G.TeamsUpdateDiscussionCommentLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a discussion comment (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a discussion comment](https://docs.github.com/rest/teams/discussion-comments#update-a-discussion-comment) endpoint.<br/>
        /// Edits the body text of a discussion comment.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="discussionNumber"></param>
        /// <param name="commentNumber"></param>
        /// <param name="body">
        /// The discussion comment's body text.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamDiscussionComment> TeamsUpdateDiscussionCommentLegacyAsync(
            int teamId,
            int discussionNumber,
            int commentNumber,
            string body,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}