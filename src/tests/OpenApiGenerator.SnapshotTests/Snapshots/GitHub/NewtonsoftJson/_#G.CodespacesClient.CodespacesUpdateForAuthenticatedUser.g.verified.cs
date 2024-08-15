//HintName: G.CodespacesClient.CodespacesUpdateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesUpdateForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string codespaceName,
            global::G.CodespacesUpdateForAuthenticatedUserRequest request);
        partial void PrepareCodespacesUpdateForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string codespaceName,
            global::G.CodespacesUpdateForAuthenticatedUserRequest request);
        partial void ProcessCodespacesUpdateForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesUpdateForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            global::G.CodespacesUpdateForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesUpdateForAuthenticatedUserArguments(
                httpClient: _httpClient,
                codespaceName: ref codespaceName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/codespaces/{codespaceName}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesUpdateForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                codespaceName: codespaceName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesUpdateForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesUpdateForAuthenticatedUserResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Codespace?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="machine">
        /// A valid machine to transition this codespace to.
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="recentFolders">
        /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            string? machine = default,
            string? displayName = default,
            global::System.Collections.Generic.IList<string>? recentFolders = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodespacesUpdateForAuthenticatedUserRequest
            {
                Machine = machine,
                DisplayName = displayName,
                RecentFolders = recentFolders,
            };

            return await CodespacesUpdateForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}