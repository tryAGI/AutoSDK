//HintName: G.AppsClient.AppsListAccountsForPlan.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        /// <summary>
        /// List accounts for a plan
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task AppsListAccountsForPlanAsync(
            int planId,
            AppsListAccountsForPlanSort sort,
            AppsListAccountsForPlanDirection direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sortValue = sort switch
            {
                AppsListAccountsForPlanSort.Created => "created",
                AppsListAccountsForPlanSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                AppsListAccountsForPlanDirection.Asc => "asc",
                AppsListAccountsForPlanDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/marketplace_listing/plans/{planId}/accounts?sort={sortValue}&direction={directionValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}