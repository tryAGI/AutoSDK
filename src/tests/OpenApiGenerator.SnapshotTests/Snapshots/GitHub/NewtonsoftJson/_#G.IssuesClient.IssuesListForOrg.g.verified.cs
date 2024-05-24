//HintName: G.IssuesClient.IssuesListForOrg.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// List organization issues assigned to the authenticated user
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter"></param>
        /// <param name="state"></param>
        /// <param name="labels"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task IssuesListForOrgAsync(
            string org,
            IssuesListForOrgFilter filter,
            IssuesListForOrgState state,
            string labels,
            IssuesListForOrgSort sort,
            IssuesListForOrgDirection direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filterValue = filter switch
            {
                IssuesListForOrgFilter.Assigned => "assigned",
                IssuesListForOrgFilter.Created => "created",
                IssuesListForOrgFilter.Mentioned => "mentioned",
                IssuesListForOrgFilter.Subscribed => "subscribed",
                IssuesListForOrgFilter.Repos => "repos",
                IssuesListForOrgFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                IssuesListForOrgState.Open => "open",
                IssuesListForOrgState.Closed => "closed",
                IssuesListForOrgState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                IssuesListForOrgSort.Created => "created",
                IssuesListForOrgSort.Updated => "updated",
                IssuesListForOrgSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                IssuesListForOrgDirection.Asc => "asc",
                IssuesListForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/issues?filter={filterValue}&state={stateValue}&labels={labels}&sort={sortValue}&direction={directionValue}&since={since}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}