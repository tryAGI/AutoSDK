//HintName: G.OrgsClient.OrgsListMembershipsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List organization memberships for the authenticated user
        /// </summary>
        /// <param name="state"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsListMembershipsForAuthenticatedUserAsync(
            OrgsListMembershipsForAuthenticatedUserState state,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var stateValue = state switch
            {
                OrgsListMembershipsForAuthenticatedUserState.Active => "active",
                OrgsListMembershipsForAuthenticatedUserState.Pending => "pending",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/memberships/orgs?state={stateValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}