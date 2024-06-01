//HintName: G.AppsClient.AppsCreateInstallationAccessToken.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        /// <summary>
        /// Create an installation access token for an app
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<InstallationToken> AppsCreateInstallationAccessTokenAsync(
            int installationId,
            AppsCreateInstallationAccessTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/app/installations/{installationId}/access_tokens", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<InstallationToken?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an installation access token for an app
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositories"></param>
        /// <param name="repositoryIds"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<InstallationToken> AppsCreateInstallationAccessTokenAsync(
            int installationId,
            global::System.Collections.Generic.IList<string?>? repositories = default,
            global::System.Collections.Generic.IList<int>? repositoryIds = default,
            AppPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new AppsCreateInstallationAccessTokenRequest
            {
                Repositories = repositories,
                RepositoryIds = repositoryIds,
                Permissions = permissions,
            };

            return await AppsCreateInstallationAccessTokenAsync(
                installationId: installationId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}