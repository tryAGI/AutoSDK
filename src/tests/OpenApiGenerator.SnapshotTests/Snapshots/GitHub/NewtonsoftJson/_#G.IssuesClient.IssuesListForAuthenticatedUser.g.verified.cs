//HintName: G.IssuesClient.IssuesListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// List user account issues assigned to the authenticated user
        /// </summary>
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
        public async global::System.Threading.Tasks.Task IssuesListForAuthenticatedUserAsync(
            IssuesListForAuthenticatedUserFilter filter,
            IssuesListForAuthenticatedUserState state,
            string labels,
            IssuesListForAuthenticatedUserSort sort,
            IssuesListForAuthenticatedUserDirection direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filterValue = filter switch
            {
                IssuesListForAuthenticatedUserFilter.Assigned => "assigned",
                IssuesListForAuthenticatedUserFilter.Created => "created",
                IssuesListForAuthenticatedUserFilter.Mentioned => "mentioned",
                IssuesListForAuthenticatedUserFilter.Subscribed => "subscribed",
                IssuesListForAuthenticatedUserFilter.Repos => "repos",
                IssuesListForAuthenticatedUserFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                IssuesListForAuthenticatedUserState.Open => "open",
                IssuesListForAuthenticatedUserState.Closed => "closed",
                IssuesListForAuthenticatedUserState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                IssuesListForAuthenticatedUserSort.Created => "created",
                IssuesListForAuthenticatedUserSort.Updated => "updated",
                IssuesListForAuthenticatedUserSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                IssuesListForAuthenticatedUserDirection.Asc => "asc",
                IssuesListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/issues?filter={filterValue}&state={stateValue}&labels={labels}&sort={sortValue}&direction={directionValue}&since={since}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}