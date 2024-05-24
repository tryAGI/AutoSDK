//HintName: G.TeamsClient.TeamsListMembersLegacy.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// List team members (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="role"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TeamsListMembersLegacyAsync(
            int teamId,
            TeamsListMembersLegacyRole role,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var roleValue = role switch
            {
                TeamsListMembersLegacyRole.Member => "member",
                TeamsListMembersLegacyRole.Maintainer => "maintainer",
                TeamsListMembersLegacyRole.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/teams/{teamId}/members?role={roleValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}