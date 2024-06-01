//HintName: G.TeamsClient.TeamsCreate.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        /// <summary>
        /// Create a team
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsCreateAsync(
            string org,
            TeamsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/teams", global::System.UriKind.RelativeOrAbsolute));
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
        /// Create a team
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maintainers"></param>
        /// <param name="repoNames"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="permission"></param>
        /// <param name="parentTeamId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TeamFull> TeamsCreateAsync(
            string org,
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<string?>? maintainers = default,
            global::System.Collections.Generic.IList<string?>? repoNames = default,
            TeamsCreateRequestPrivacy? privacy = default,
            TeamsCreateRequestNotificationSetting? notificationSetting = default,
            TeamsCreateRequestPermission? permission = TeamsCreateRequestPermission.Pull,
            int parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new TeamsCreateRequest
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