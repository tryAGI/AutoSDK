//HintName: G.TeamsClient.TeamsAddOrUpdateMembershipForUserInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsAddOrUpdateMembershipForUserInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref string username,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequest request);
        partial void PrepareTeamsAddOrUpdateMembershipForUserInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            string username,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequest request);
        partial void ProcessTeamsAddOrUpdateMembershipForUserInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsAddOrUpdateMembershipForUserInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add or update team membership for a user<br/>
        /// Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.<br/>
        /// Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see "[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/)."<br/>
        /// An organization owner can add someone who is not part of the team's organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the "pending" state until the person accepts the invitation, at which point the membership will transition to the "active" state and the user will be added as a member of the team.<br/>
        /// If the user is already a member of the team, this endpoint will update the role of the team member's role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/memberships/{username}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamMembership> TeamsAddOrUpdateMembershipForUserInOrgAsync(
            string org,
            string teamSlug,
            string username,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTeamsAddOrUpdateMembershipForUserInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                username: ref username,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}/memberships/{username}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsAddOrUpdateMembershipForUserInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                username: username,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsAddOrUpdateMembershipForUserInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsAddOrUpdateMembershipForUserInOrgResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamMembership?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add or update team membership for a user<br/>
        /// Adds an organization member to a team. An authenticated organization owner or team maintainer can add organization members to a team.<br/>
        /// Team synchronization is available for organizations using GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// **Note:** When you have team synchronization set up for a team with your organization's identity provider (IdP), you will see an error if you attempt to use the API for making changes to the team's membership. If you have access to manage group membership in your IdP, you can manage GitHub team membership through your identity provider, which automatically adds and removes team members in an organization. For more information, see "[Synchronizing teams between your identity provider and GitHub](https://docs.github.com/articles/synchronizing-teams-between-your-identity-provider-and-github/)."<br/>
        /// An organization owner can add someone who is not part of the team's organization to a team. When an organization owner adds someone to a team who is not an organization member, this endpoint will send an invitation to the person via email. This newly-created membership will be in the "pending" state until the person accepts the invitation, at which point the membership will transition to the "active" state and the user will be added as a member of the team.<br/>
        /// If the user is already a member of the team, this endpoint will update the role of the team member's role. To update the membership of a team member, the authenticated user must be an organization owner or a team maintainer.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `PUT /organizations/{org_id}/team/{team_id}/memberships/{username}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="username"></param>
        /// <param name="role">
        /// The role that this user should have in the team.<br/>
        /// Default Value: member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamMembership> TeamsAddOrUpdateMembershipForUserInOrgAsync(
            string org,
            string teamSlug,
            string username,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? role = global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole.Member,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TeamsAddOrUpdateMembershipForUserInOrgRequest
            {
                Role = role,
            };

            return await TeamsAddOrUpdateMembershipForUserInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                username: username,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}