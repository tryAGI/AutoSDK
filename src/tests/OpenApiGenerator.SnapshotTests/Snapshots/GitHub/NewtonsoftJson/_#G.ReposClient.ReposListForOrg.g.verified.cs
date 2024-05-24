//HintName: G.ReposClient.ReposListForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List organization repositories
        /// </summary>
        /// <param name="org"></param>
        /// <param name="type"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ReposListForOrgAsync(
            string org,
            ReposListForOrgType type,
            ReposListForOrgSort sort,
            ReposListForOrgDirection direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var typeValue = type switch
            {
                ReposListForOrgType.All => "all",
                ReposListForOrgType.Public => "public",
                ReposListForOrgType.Private => "private",
                ReposListForOrgType.Forks => "forks",
                ReposListForOrgType.Sources => "sources",
                ReposListForOrgType.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                ReposListForOrgSort.Created => "created",
                ReposListForOrgSort.Updated => "updated",
                ReposListForOrgSort.Pushed => "pushed",
                ReposListForOrgSort.FullName => "full_name",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                ReposListForOrgDirection.Asc => "asc",
                ReposListForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/repos?type={typeValue}&sort={sortValue}&direction={directionValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}