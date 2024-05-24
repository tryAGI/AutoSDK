//HintName: G.IssuesClient.IssuesList.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// List issues assigned to the authenticated user
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="state"></param>
        /// <param name="labels"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task IssuesListAsync(
            IssuesListFilter filter,
            IssuesListState state,
            string labels,
            IssuesListSort sort,
            IssuesListDirection direction,
            global::System.DateTime since,
            bool collab,
            bool orgs,
            bool owned,
            bool pulls,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filterValue = filter switch
            {
                IssuesListFilter.Assigned => "assigned",
                IssuesListFilter.Created => "created",
                IssuesListFilter.Mentioned => "mentioned",
                IssuesListFilter.Subscribed => "subscribed",
                IssuesListFilter.Repos => "repos",
                IssuesListFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                IssuesListState.Open => "open",
                IssuesListState.Closed => "closed",
                IssuesListState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                IssuesListSort.Created => "created",
                IssuesListSort.Updated => "updated",
                IssuesListSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                IssuesListDirection.Asc => "asc",
                IssuesListDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/issues?filter={filterValue}&state={stateValue}&labels={labels}&sort={sortValue}&direction={directionValue}&since={since}&collab={collab}&orgs={orgs}&owned={owned}&pulls={pulls}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}