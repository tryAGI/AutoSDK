//HintName: G.CodespacesClient.CodespacesCreateWithPrForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesCreateWithPrForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int pullNumber,
            global::G.CodespacesCreateWithPrForAuthenticatedUserRequest request);
        partial void PrepareCodespacesCreateWithPrForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int pullNumber,
            global::G.CodespacesCreateWithPrForAuthenticatedUserRequest request);
        partial void ProcessCodespacesCreateWithPrForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesCreateWithPrForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a codespace from a pull request<br/>
        /// Creates a codespace owned by the authenticated user for the specified pull request.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateWithPrForAuthenticatedUserAsync(
            string owner,
            string repo,
            int pullNumber,
            global::G.CodespacesCreateWithPrForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesCreateWithPrForAuthenticatedUserArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                pullNumber: ref pullNumber,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/pulls/{pullNumber}/codespaces",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesCreateWithPrForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesCreateWithPrForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesCreateWithPrForAuthenticatedUserResponseContent(
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
                global::G.Codespace.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a codespace from a pull request<br/>
        /// Creates a codespace owned by the authenticated user for the specified pull request.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="location">
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </param>
        /// <param name="geo">
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </param>
        /// <param name="clientIp">
        /// IP for location auto-detection when proxying a request
        /// </param>
        /// <param name="machine">
        /// Machine type to use for this codespace
        /// </param>
        /// <param name="devcontainerPath">
        /// Path to devcontainer.json config to use for this codespace
        /// </param>
        /// <param name="multiRepoPermissionsOptOut">
        /// Whether to authorize requested permissions from devcontainer.json
        /// </param>
        /// <param name="workingDirectory">
        /// Working directory for this codespace
        /// </param>
        /// <param name="idleTimeoutMinutes">
        /// Time in minutes before codespace stops from inactivity
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="retentionPeriodMinutes">
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateWithPrForAuthenticatedUserAsync(
            string owner,
            string repo,
            int pullNumber,
            string? location = default,
            global::G.CodespacesCreateWithPrForAuthenticatedUserRequestGeo? geo = default,
            string? clientIp = default,
            string? machine = default,
            string? devcontainerPath = default,
            bool? multiRepoPermissionsOptOut = default,
            string? workingDirectory = default,
            int? idleTimeoutMinutes = default,
            string? displayName = default,
            int? retentionPeriodMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodespacesCreateWithPrForAuthenticatedUserRequest
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