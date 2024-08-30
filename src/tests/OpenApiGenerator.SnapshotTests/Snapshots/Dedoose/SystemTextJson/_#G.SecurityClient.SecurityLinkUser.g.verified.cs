//HintName: G.SecurityClient.SecurityLinkUser.g.cs

#nullable enable

namespace G
{
    public partial class SecurityClient
    {
        partial void PrepareSecurityLinkUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? userId,
            ref string? projectId,
            ref string? groupId);
        partial void PrepareSecurityLinkUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? userId,
            string? projectId,
            string? groupId);
        partial void ProcessSecurityLinkUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityLinkUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// LinkUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SecurityLinkUserResponse> SecurityLinkUserAsync(
            string? token = default,
            string? userId = default,
            string? projectId = default,
            string? groupId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityLinkUserArguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId,
                projectId: ref projectId,
                groupId: ref groupId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/security/linkuser?userId={userId}&projectId={projectId}&groupId={groupId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityLinkUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId,
                projectId: projectId,
                groupId: groupId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityLinkUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityLinkUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.SecurityLinkUserResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}