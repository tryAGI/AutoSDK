//HintName: G.Api.OpenRemoveSpaceMember.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenRemoveSpaceMemberSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenRemoveSpaceMemberSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenRemoveSpaceMemberSecurityRequirement0,
            };
        partial void PrepareOpenRemoveSpaceMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId,
            global::G.OpenRemoveSpaceMemberRequest request);
        partial void PrepareOpenRemoveSpaceMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId,
            global::G.OpenRemoveSpaceMemberRequest request);
        partial void ProcessOpenRemoveSpaceMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenRemoveSpaceMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 批量移除空间中的用户<br/>
        /// {"0":{"ops":[{"insert":"批量移除空间中的用户。\n"},{"attributes":{"anchor":"3011aa0f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用本 API 将用户从指定的工作空间中移除。只能移除空间管理员或成员，不支持移除空间所有者。批量移除用户时，你可以在返回结果中查看移除失败的用户以及具体原因。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenRemoveSpaceMemberResponse> OpenRemoveSpaceMemberAsync(
            string workspaceId,

            global::G.OpenRemoveSpaceMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenRemoveSpaceMemberArguments(
                httpClient: HttpClient,
                workspaceId: ref workspaceId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenRemoveSpaceMemberSecurityRequirements,
                operationName: "OpenRemoveSpaceMemberAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/workspaces/{workspaceId}/members",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareOpenRemoveSpaceMemberRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceId: workspaceId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenRemoveSpaceMemberResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOpenRemoveSpaceMemberResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenRemoveSpaceMemberResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.OpenRemoveSpaceMemberResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// 批量移除空间中的用户<br/>
        /// {"0":{"ops":[{"insert":"批量移除空间中的用户。\n"},{"attributes":{"anchor":"3011aa0f","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"调用本 API 将用户从指定的工作空间中移除。只能移除空间管理员或成员，不支持移除空间所有者。批量移除用户时，你可以在返回结果中查看移除失败的用户以及具体原因。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="userIds">
        /// 要移除的成员，数量最多5
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenRemoveSpaceMemberResponse> OpenRemoveSpaceMemberAsync(
            string workspaceId,
            global::System.Collections.Generic.IList<string> userIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenRemoveSpaceMemberRequest
            {
                UserIds = userIds,
            };

            return await OpenRemoveSpaceMemberAsync(
                workspaceId: workspaceId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}