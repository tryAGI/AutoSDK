//HintName: G.IReactionsClient.ReactionsCreateForIssueComment.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Create reaction for an issue comment<br/>
        /// Create a reaction to an [issue comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment). A response with an HTTP `200` status means that you already added the reaction type to this issue comment.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForIssueCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::G.ReactionsCreateForIssueCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create reaction for an issue comment<br/>
        /// Create a reaction to an [issue comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment). A response with an HTTP `200` status means that you already added the reaction type to this issue comment.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue comment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Reaction> ReactionsCreateForIssueCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::G.ReactionsCreateForIssueCommentRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}