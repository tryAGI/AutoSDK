//HintName: G.SearchClient.SearchIssuesAndPullRequests.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        /// <summary>
        /// Search issues and pull requests
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SearchIssuesAndPullRequestsAsync(
            string q,
            SearchIssuesAndPullRequestsSort sort,
            SearchIssuesAndPullRequestsOrder order,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sortValue = sort switch
            {
                SearchIssuesAndPullRequestsSort.Comments => "comments",
                SearchIssuesAndPullRequestsSort.Reactions => "reactions",
                SearchIssuesAndPullRequestsSort.ReactionsPlus1 => "reactions-+1",
                SearchIssuesAndPullRequestsSort.Reactions1 => "reactions--1",
                SearchIssuesAndPullRequestsSort.ReactionsSmile => "reactions-smile",
                SearchIssuesAndPullRequestsSort.ReactionsThinkingFace => "reactions-thinking_face",
                SearchIssuesAndPullRequestsSort.ReactionsHeart => "reactions-heart",
                SearchIssuesAndPullRequestsSort.ReactionsTada => "reactions-tada",
                SearchIssuesAndPullRequestsSort.Interactions => "interactions",
                SearchIssuesAndPullRequestsSort.Created => "created",
                SearchIssuesAndPullRequestsSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderValue = order switch
            {
                SearchIssuesAndPullRequestsOrder.Desc => "desc",
                SearchIssuesAndPullRequestsOrder.Asc => "asc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/search/issues?q={q}&sort={sortValue}&order={orderValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}