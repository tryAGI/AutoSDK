//HintName: G.CodespacesClient.CodespacesRepoMachinesForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesRepoMachinesForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? location,
            ref string? clientIp,
            ref string? @ref);
        partial void PrepareCodespacesRepoMachinesForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? location,
            string? clientIp,
            string? @ref);
        partial void ProcessCodespacesRepoMachinesForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesRepoMachinesForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List available machine types for a repository<br/>
        /// List the machine types available for a given repository based on its configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="location">
        /// Example: WestUs2
        /// </param>
        /// <param name="clientIp"></param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodespacesRepoMachinesForAuthenticatedUserResponse> CodespacesRepoMachinesForAuthenticatedUserAsync(
            string owner,
            string repo,
            string? location = default,
            string? clientIp = default,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesRepoMachinesForAuthenticatedUserArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                location: ref location,
                clientIp: ref clientIp,
                @ref: ref @ref);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/codespaces/machines?location={location}&client_ip={clientIp}&ref={@ref}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesRepoMachinesForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                location: location,
                clientIp: clientIp,
                @ref: @ref);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesRepoMachinesForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesRepoMachinesForAuthenticatedUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespacesRepoMachinesForAuthenticatedUserResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}