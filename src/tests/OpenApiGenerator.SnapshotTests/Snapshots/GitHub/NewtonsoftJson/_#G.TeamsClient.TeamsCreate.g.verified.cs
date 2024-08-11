//HintName: G.TeamsClient.TeamsCreate.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.TeamsCreateRequest request);
        partial void PrepareTeamsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.TeamsCreateRequest request);
        partial void ProcessTeamsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTeamsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a team<br/>
        /// To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see "[Setting team creation permissions](https://docs.github.com/articles/setting-team-creation-permissions-in-your-organization)."<br/>
        /// When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see "[About teams](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/about-teams)".
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsCreateAsync(
            string org,
            global::G.TeamsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareTeamsCreateArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/teams", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTeamsCreateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTeamsCreateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTeamsCreateResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamFull?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a team<br/>
        /// To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see "[Setting team creation permissions](https://docs.github.com/articles/setting-team-creation-permissions-in-your-organization)."<br/>
        /// When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see "[About teams](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/about-teams)".
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="maintainers">
        /// List GitHub IDs for organization members who will become team maintainers.
        /// </param>
        /// <param name="repoNames">
        /// The full name (e.g., "organization-name/repository-name") of repositories to add the team to.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default: `secret`  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default for child team: `closed`
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. The options are:  <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.  <br/>
        /// Default: `notifications_enabled`
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
        public async global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsCreateAsync(
            string org,
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<string>? maintainers = default,
            global::System.Collections.Generic.IList<string>? repoNames = default,
            global::G.TeamsCreateRequestPrivacy? privacy = default,
            global::G.TeamsCreateRequestNotificationSetting? notificationSetting = default,
            global::G.TeamsCreateRequestPermission? permission = global::G.TeamsCreateRequestPermission.Pull,
            int parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TeamsCreateRequest
            {
                Name = name,
                Description = description,
                Maintainers = maintainers,
                RepoNames = repoNames,
                Privacy = privacy,
                NotificationSetting = notificationSetting,
                Permission = permission,
                ParentTeamId = parentTeamId,
            };

            return await TeamsCreateAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}