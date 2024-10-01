//HintName: G.WorkspacesClient.PatchCurrentWorkspaceMember.g.cs

#nullable enable

namespace G
{
    public partial class WorkspacesClient
    {
        partial void PreparePatchCurrentWorkspaceMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid identityId,
            global::G.IdentityPatch request);
        partial void PreparePatchCurrentWorkspaceMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid identityId,
            global::G.IdentityPatch request);
        partial void ProcessPatchCurrentWorkspaceMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchCurrentWorkspaceMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::G.IdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchCurrentWorkspaceMemberArguments(
                httpClient: _httpClient,
                identityId: ref identityId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/workspaces/current/members/{identityId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchCurrentWorkspaceMemberRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                identityId: identityId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchCurrentWorkspaceMemberResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchCurrentWorkspaceMemberResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::System.Guid roleId,
            global::G.AnyOf<bool?, object>? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.IdentityPatch
            {
                ReadOnly = readOnly,
                RoleId = roleId,
            };

            return await PatchCurrentWorkspaceMemberAsync(
                identityId: identityId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}