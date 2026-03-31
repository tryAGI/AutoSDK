//HintName: G.Api.OpenAPIAddEnterpriseMember.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIAddEnterpriseMemberArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterpriseId,
            global::G.OpenAPIAddEnterpriseMemberRequest request);
        partial void PrepareOpenAPIAddEnterpriseMemberRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterpriseId,
            global::G.OpenAPIAddEnterpriseMemberRequest request);
        partial void ProcessOpenAPIAddEnterpriseMemberResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIAddEnterpriseMemberResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 添加企业成员<br/>
        /// {"0":{"ops":[{"insert":"添加员工到企业。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在火山引擎创建用户后，"},{"attributes":{"bold":"true"},"insert":"默认会自动将用户添加至企业"},{"insert":"，若未成功添加，你可以调用本 API 将用户添加至企业。火山引擎创建用户的具体方法请参见"},{"insert":"成员管理","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_coze_user\",\"linkId\":\"jV1h6CJAd7\"}"}},{"insert":"。\n"},{"attributes":{"anchor":"c1f43b73","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"本 API 仅支持添加员工（火山子用户），不支持添加外部成员（访客）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加成员总数不能超过企业标准版权益中的成员数量上限（100 个成员），否则会提示 777074011错误。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"UteVasdpeJ","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"UteVasdpeJ":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"UteVasdpeJ","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIAddEnterpriseMemberResponse> OpenAPIAddEnterpriseMemberAsync(
            string enterpriseId,

            global::G.OpenAPIAddEnterpriseMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIAddEnterpriseMemberArguments(
                httpClient: HttpClient,
                enterpriseId: ref enterpriseId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/enterprises/{enterpriseId}/members",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareOpenAPIAddEnterpriseMemberRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enterpriseId: enterpriseId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIAddEnterpriseMemberResponse(
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
                ProcessOpenAPIAddEnterpriseMemberResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIAddEnterpriseMemberResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIAddEnterpriseMemberResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 添加企业成员<br/>
        /// {"0":{"ops":[{"insert":"添加员工到企业。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"在火山引擎创建用户后，"},{"attributes":{"bold":"true"},"insert":"默认会自动将用户添加至企业"},{"insert":"，若未成功添加，你可以调用本 API 将用户添加至企业。火山引擎创建用户的具体方法请参见"},{"insert":"成员管理","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/create_coze_user\",\"linkId\":\"jV1h6CJAd7\"}"}},{"insert":"。\n"},{"attributes":{"anchor":"c1f43b73","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"本 API 仅支持添加员工（火山子用户），不支持添加外部成员（访客）。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"添加成员总数不能超过企业标准版权益中的成员数量上限（100 个成员），否则会提示 777074011错误。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"UteVasdpeJ","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"UteVasdpeJ":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"UteVasdpeJ","zoneType":"Z"}}
        /// </summary>
        /// <param name="enterpriseId"></param>
        /// <param name="users"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIAddEnterpriseMemberResponse> OpenAPIAddEnterpriseMemberAsync(
            string enterpriseId,
            global::System.Collections.Generic.IList<global::G.PropertiesUsersItems>? users = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.OpenAPIAddEnterpriseMemberRequest
            {
                Users = users,
            };

            return await OpenAPIAddEnterpriseMemberAsync(
                enterpriseId: enterpriseId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}