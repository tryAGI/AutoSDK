//HintName: G.TeamsClient.TeamsUpdateLegacy.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Update a team (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsUpdateLegacyAsync(
            int teamId,
            TeamsUpdateLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/teams/{teamId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<TeamFull?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a team (Legacy)
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="permission"></param>
        /// <param name="parentTeamId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsUpdateLegacyAsync(
            int teamId,
            string name,
            string? description = default,
            TeamsUpdateLegacyRequestPrivacy? privacy = default,
            TeamsUpdateLegacyRequestNotificationSetting? notificationSetting = default,
            TeamsUpdateLegacyRequestPermission? permission = TeamsUpdateLegacyRequestPermission.Pull,
            int? parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TeamsUpdateLegacyRequest
            {
                Name = name,
                Description = description,
                Privacy = privacy,
                NotificationSetting = notificationSetting,
                Permission = permission,
                ParentTeamId = parentTeamId,
            };

            return await TeamsUpdateLegacyAsync(
                teamId: teamId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}