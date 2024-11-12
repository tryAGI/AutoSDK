//HintName: G.IIssuesClient.IssuesDeleteComment.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Delete an issue comment<br/>
        /// You can use the REST API to delete comments on issues and pull requests. Every pull request is an issue, but not every issue is a pull request.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task IssuesDeleteCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}