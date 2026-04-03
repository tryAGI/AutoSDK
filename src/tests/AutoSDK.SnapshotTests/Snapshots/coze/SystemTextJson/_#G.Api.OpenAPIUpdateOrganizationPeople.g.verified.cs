//HintName: G.Api.OpenAPIUpdateOrganizationPeople.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIUpdateOrganizationPeopleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            ref string userId,
            global::G.OpenAPIUpdateOrganizationPeopleRequest request);
        partial void PrepareOpenAPIUpdateOrganizationPeopleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            string userId,
            global::G.OpenAPIUpdateOrganizationPeopleRequest request);
        partial void ProcessOpenAPIUpdateOrganizationPeopleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIUpdateOrganizationPeopleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 修改组织成员的角色<br/>
        /// {"0":{"ops":[{"insert":"修改组织成员的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"组织成员角色包括组织超级管理员、组织管理员、组织成员和访客。你可以通过本 API 修改组织成员的角色。\n"},{"attributes":{"anchor":"28ae56c4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"企业外部用户的角色只能是访客，不支持修改。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业员工的角色不能设置为访客。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织管理员不能将其他人设为组织超级管理员，只有组织超级管理员创建的访问令牌能设置其他人为组织超级管理员。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationPeopleResponse> OpenAPIUpdateOrganizationPeopleAsync(
            string organizationId,
            string userId,

            global::G.OpenAPIUpdateOrganizationPeopleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIUpdateOrganizationPeopleArguments(
                httpClient: HttpClient,
                organizationId: ref organizationId,
                userId: ref userId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/organizations/{organizationId}/members/{userId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareOpenAPIUpdateOrganizationPeopleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationId: organizationId,
                userId: userId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIUpdateOrganizationPeopleResponse(
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
                ProcessOpenAPIUpdateOrganizationPeopleResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIUpdateOrganizationPeopleResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIUpdateOrganizationPeopleResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 修改组织成员的角色<br/>
        /// {"0":{"ops":[{"insert":"修改组织成员的角色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"组织成员角色包括组织超级管理员、组织管理员、组织成员和访客。你可以通过本 API 修改组织成员的角色。\n"},{"attributes":{"anchor":"28ae56c4","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"企业外部用户的角色只能是访客，不支持修改。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"企业员工的角色不能设置为访客。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"组织管理员不能将其他人设为组织超级管理员，只有组织超级管理员创建的访问令牌能设置其他人为组织超级管理员。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="organizationRoleType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIUpdateOrganizationPeopleResponse> OpenAPIUpdateOrganizationPeopleAsync(
            string organizationId,
            string userId,
            global::G.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType organizationRoleType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIUpdateOrganizationPeopleRequest
            {
                OrganizationRoleType = organizationRoleType,
            };

            return await OpenAPIUpdateOrganizationPeopleAsync(
                organizationId: organizationId,
                userId: userId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}