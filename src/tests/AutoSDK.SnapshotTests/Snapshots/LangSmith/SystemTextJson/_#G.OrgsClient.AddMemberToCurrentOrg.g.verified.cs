//HintName: G.OrgsClient.AddMemberToCurrentOrg.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareAddMemberToCurrentOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PendingIdentityCreate request);
        partial void PrepareAddMemberToCurrentOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PendingIdentityCreate request);
        partial void ProcessAddMemberToCurrentOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddMemberToCurrentOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PendingIdentity> AddMemberToCurrentOrgAsync(
            global::G.PendingIdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddMemberToCurrentOrgArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/orgs/current/members",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAddMemberToCurrentOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAddMemberToCurrentOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAddMemberToCurrentOrgResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.PendingIdentity.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="email"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PendingIdentity> AddMemberToCurrentOrgAsync(
            string email,
            bool? readOnly = false,
            global::System.Guid? roleId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds = default,
            global::System.Guid? workspaceRoleId = default,
            string? password = default,
            string? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PendingIdentityCreate
            {
                Email = email,
                ReadOnly = readOnly,
                RoleId = roleId,
                WorkspaceIds = workspaceIds,
                WorkspaceRoleId = workspaceRoleId,
                Password = password,
                FullName = fullName,
            };

            return await AddMemberToCurrentOrgAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}