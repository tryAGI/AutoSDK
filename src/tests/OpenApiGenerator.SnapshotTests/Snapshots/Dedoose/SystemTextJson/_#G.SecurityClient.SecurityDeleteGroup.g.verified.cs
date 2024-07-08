//HintName: G.SecurityClient.SecurityDeleteGroup.g.cs

#nullable enable

namespace G
{
    public partial class SecurityClient
    {
        partial void PrepareSecurityDeleteGroupArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectIdKey,
            ref string projectId,
            ref string id,
            ref string projectIDL,
            ref string title,
            ref string accessListIDL);
        partial void PrepareSecurityDeleteGroupRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string accessListIDL);
        partial void ProcessSecurityDeleteGroupResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityDeleteGroupResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteGroup.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="accessListIDL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UserGroup> SecurityDeleteGroupAsync(
            string token,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string accessListIDL,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityDeleteGroupArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                title: ref title,
                accessListIDL: ref accessListIDL);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/security/deletegroup?ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&AccessListIDL={accessListIDL}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityDeleteGroupRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                title: title,
                accessListIDL: accessListIDL);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityDeleteGroupResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityDeleteGroupResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UserGroup?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}