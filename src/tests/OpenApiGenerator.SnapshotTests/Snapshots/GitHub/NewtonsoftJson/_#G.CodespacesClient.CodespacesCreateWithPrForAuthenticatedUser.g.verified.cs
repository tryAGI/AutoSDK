//HintName: G.CodespacesClient.CodespacesCreateWithPrForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Create a codespace from a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesCreateWithPrForAuthenticatedUserAsync(
            string owner,
            string repo,
            int pullNumber,
            CodespacesCreateWithPrForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/{pullNumber}/codespaces", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Codespace?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a codespace from a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
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
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesCreateWithPrForAuthenticatedUserAsync(
            string owner,
            string repo,
            int pullNumber,
            string? location = default,
            CodespacesCreateWithPrForAuthenticatedUserRequestGeo? geo = default,
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
            var request = new CodespacesCreateWithPrForAuthenticatedUserRequest
            {
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

            return await CodespacesCreateWithPrForAuthenticatedUserAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}