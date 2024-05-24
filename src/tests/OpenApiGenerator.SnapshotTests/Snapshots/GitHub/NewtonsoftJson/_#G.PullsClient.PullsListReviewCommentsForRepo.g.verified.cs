//HintName: G.PullsClient.PullsListReviewCommentsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// List review comments in a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PullsListReviewCommentsForRepoAsync(
            string owner,
            string repo,
            PullsListReviewCommentsForRepoSort sort,
            PullsListReviewCommentsForRepoDirection direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sortValue = sort switch
            {
                PullsListReviewCommentsForRepoSort.Created => "created",
                PullsListReviewCommentsForRepoSort.Updated => "updated",
                PullsListReviewCommentsForRepoSort.CreatedAt => "created_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                PullsListReviewCommentsForRepoDirection.Asc => "asc",
                PullsListReviewCommentsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/comments?sort={sortValue}&direction={directionValue}&since={since}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}