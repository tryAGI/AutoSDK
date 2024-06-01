//HintName: G.OrgsClient.OrgsSetMembershipForUser.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Set organization membership for a user
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            OrgsSetMembershipForUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/memberships/{username}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<OrgMembership?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set organization membership for a user
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            OrgsSetMembershipForUserRequestRole? role = OrgsSetMembershipForUserRequestRole.Member,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsSetMembershipForUserRequest
            {
                Role = role,
            };

            return await OrgsSetMembershipForUserAsync(
                org: org,
                username: username,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}