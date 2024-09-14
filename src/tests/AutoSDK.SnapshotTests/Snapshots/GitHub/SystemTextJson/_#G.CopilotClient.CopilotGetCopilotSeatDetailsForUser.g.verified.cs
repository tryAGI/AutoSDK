//HintName: G.CopilotClient.CopilotGetCopilotSeatDetailsForUser.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotGetCopilotSeatDetailsForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string username);
        partial void PrepareCopilotGetCopilotSeatDetailsForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string username);
        partial void ProcessCopilotGetCopilotSeatDetailsForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotGetCopilotSeatDetailsForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Copilot seat assignment details for a user<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// Gets the GitHub Copilot seat assignment details for a member of an organization who currently has access to GitHub Copilot.<br/>
        /// Organization owners can view GitHub Copilot seat assignment details for members in their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotSeatDetails> CopilotGetCopilotSeatDetailsForUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCopilotGetCopilotSeatDetailsForUserArguments(
                httpClient: _httpClient,
                org: ref org,
                username: ref username);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/members/{username}/copilot", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCopilotGetCopilotSeatDetailsForUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                username: username);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCopilotGetCopilotSeatDetailsForUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCopilotGetCopilotSeatDetailsForUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CopilotSeatDetails?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}