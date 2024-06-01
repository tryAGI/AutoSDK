//HintName: G.CodespacesClient.CodespacesCreateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Create a codespace for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::System.OneOf<CodespacesCreateForAuthenticatedUserRequest, CodespacesCreateForAuthenticatedUserRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/user/codespaces", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<Codespace?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a codespace for the authenticated user
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="@ref"></param>
        /// <param name="location"></param>
        /// <param name="geo"></param>
        /// <param name="clientIp"></param>
        /// <param name="machine"></param>
        /// <param name="devcontainerPath"></param>
        /// <param name="multiRepoPermissionsOptOut"></param>
        /// <param name="workingDirectory"></param>
        /// <param name="idleTimeoutMinutes"></param>
        /// <param name="displayName"></param>
        /// <param name="retentionPeriodMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesCreateForAuthenticatedUserAsync(
            int repositoryId,
            string? @ref = default,
            string? location = default,
            CodespacesCreateForAuthenticatedUserRequestGeo? geo = default,
            string? clientIp = default,
            string? machine = default,
            string? devcontainerPath = default,
            bool multiRepoPermissionsOptOut = default,
            string? workingDirectory = default,
            int idleTimeoutMinutes = default,
            string? displayName = default,
            int retentionPeriodMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.OneOf<CodespacesCreateForAuthenticatedUserRequest, CodespacesCreateForAuthenticatedUserRequest>
            {
                RepositoryId = repositoryId,
                Ref = @ref,
                Location = location,
                Geo = geo,
                ClientIp = clientIp,
                Machine = machine,
                DevcontainerPath = devcontainerPath,
                MultiRepoPermissionsOptOut = multiRepoPermissionsOptOut,
                WorkingDirectory = workingDirectory,
                IdleTimeoutMinutes = idleTimeoutMinutes,
                DisplayName = displayName,
                RetentionPeriodMinutes = retentionPeriodMinutes,
            };

            return await CodespacesCreateForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}