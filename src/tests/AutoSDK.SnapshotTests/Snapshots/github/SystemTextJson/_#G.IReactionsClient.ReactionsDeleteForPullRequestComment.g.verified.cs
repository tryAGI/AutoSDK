//HintName: G.IReactionsClient.ReactionsDeleteForPullRequestComment.g.cs
#nullable enable

namespace G
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Delete a pull request comment reaction<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a repository by `repository_id` using the route `DELETE /repositories/:repository_id/pulls/comments/:comment_id/reactions/:reaction_id.`<br/>
        /// Delete a reaction to a [pull request review comment](https://docs.github.com/rest/pulls/comments#get-a-review-comment-for-a-pull-request).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="reactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReactionsDeleteForPullRequestCommentAsync(
            string owner,
            string repo,
            long commentId,
            int reactionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}