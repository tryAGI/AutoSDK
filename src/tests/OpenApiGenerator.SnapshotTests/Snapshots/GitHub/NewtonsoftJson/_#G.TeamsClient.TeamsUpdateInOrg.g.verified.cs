//HintName: G.TeamsClient.TeamsUpdateInOrg.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Update a team
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,
            TeamsUpdateInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/teams/{teamSlug}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<TeamFull?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a team
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="permission"></param>
        /// <param name="parentTeamId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,
            string? name = default,
            string? description = default,
            TeamsUpdateInOrgRequestPrivacy? privacy = default,
            TeamsUpdateInOrgRequestNotificationSetting? notificationSetting = default,
            TeamsUpdateInOrgRequestPermission? permission = TeamsUpdateInOrgRequestPermission.Pull,
            int? parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TeamsUpdateInOrgRequest
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