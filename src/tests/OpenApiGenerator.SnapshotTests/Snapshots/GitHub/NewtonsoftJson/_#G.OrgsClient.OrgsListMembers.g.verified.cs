//HintName: G.OrgsClient.OrgsListMembers.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List organization members
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter"></param>
        /// <param name="role"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsListMembersAsync(
            string org,
            OrgsListMembersFilter filter,
            OrgsListMembersRole role,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filterValue = filter switch
            {
                OrgsListMembersFilter._2faDisabled => "2fa_disabled",
                OrgsListMembersFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var roleValue = role switch
            {
                OrgsListMembersRole.All => "all",
                OrgsListMembersRole.Admin => "admin",
                OrgsListMembersRole.Member => "member",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/members?filter={filterValue}&role={roleValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}