//HintName: G.TeamsClient.TeamsUpdateInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsUpdateInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            global::G.TeamsUpdateInOrgRequest request);
        partial void PrepareTeamsUpdateInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            global::G.TeamsUpdateInOrgRequest request);
        partial void ProcessTeamsUpdateInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsUpdateInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a team<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,
            global::G.TeamsUpdateInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTeamsUpdateInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams/{teamSlug}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsUpdateInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                teamSlug: teamSlug,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsUpdateInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsUpdateInOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TeamFull?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a team<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// **Note:** You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
        /// </param>
        /// <param name="permission">
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </param>
        /// <param name="parentTeamId">
        /// The ID of a team to set as the parent team.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,
            string? name = default,
            string? description = default,
            global::G.TeamsUpdateInOrgRequestPrivacy? privacy = default,
            global::G.TeamsUpdateInOrgRequestNotificationSetting? notificationSetting = default,
            global::G.TeamsUpdateInOrgRequestPermission? permission = global::G.TeamsUpdateInOrgRequestPermission.Pull,
            int? parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TeamsUpdateInOrgRequest
            {
                Name = name,
                Description = description,
                Privacy = privacy,
                NotificationSetting = notificationSetting,
                Permission = permission,
                ParentTeamId = parentTeamId,
            };

            return await TeamsUpdateInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}