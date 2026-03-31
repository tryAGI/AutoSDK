//HintName: G.Api.OpenAPIBatchAddOrganizationPeople.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIBatchAddOrganizationPeopleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            global::G.OpenAPIBatchAddOrganizationPeopleRequest request);
        partial void PrepareOpenAPIBatchAddOrganizationPeopleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            global::G.OpenAPIBatchAddOrganizationPeopleRequest request);
        partial void ProcessOpenAPIBatchAddOrganizationPeopleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIBatchAddOrganizationPeopleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 添加组织成员<br/>
        /// {"0":{"ops":[{"insert":"添加组织成员。\n"},{"attributes":{"anchor":"11ed8408","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"用户加入企业时将自动加入默认组织。"},{"insert":"创建组织","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_organization_people\",\"linkId\":\"nodD3vENEW\"}"}},{"insert":"后，你可以调用本 API 将员工和访客加入对应组织。\n"},{"attributes":{"anchor":"4387678e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"用户加入组织前，需先将其添加至对应企业，具体请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_enterprise_member\",\"linkId\":\"pz7Z6Qp5gO\"}"},"insert":"添加企业成员"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"访客加入组织后，组织角色只能是访客。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2TogSUFtr5","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2TogSUFtr5":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"2TogSUFtr5","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIBatchAddOrganizationPeopleResponse> OpenAPIBatchAddOrganizationPeopleAsync(
            string organizationId,

            global::G.OpenAPIBatchAddOrganizationPeopleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIBatchAddOrganizationPeopleArguments(
                httpClient: HttpClient,
                organizationId: ref organizationId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/organizations/{organizationId}/members",
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
            PrepareOpenAPIBatchAddOrganizationPeopleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationId: organizationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIBatchAddOrganizationPeopleResponse(
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
                ProcessOpenAPIBatchAddOrganizationPeopleResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIBatchAddOrganizationPeopleResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIBatchAddOrganizationPeopleResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 添加组织成员<br/>
        /// {"0":{"ops":[{"insert":"添加组织成员。\n"},{"attributes":{"anchor":"11ed8408","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"用户加入企业时将自动加入默认组织。"},{"insert":"创建组织","attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_organization_people\",\"linkId\":\"nodD3vENEW\"}"}},{"insert":"后，你可以调用本 API 将员工和访客加入对应组织。\n"},{"attributes":{"anchor":"4387678e","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口限制\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"attributes":{"bold":"true"},"insert":"套餐限制"},{"insert":"：扣子企业版（企业标准版、企业旗舰版）。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"用户加入组织前，需先将其添加至对应企业，具体请参见"},{"attributes":{"hyperlink":"{\"href\":\"https://docs.coze.cn/developer_guides/add_enterprise_member\",\"linkId\":\"pz7Z6Qp5gO\"}"},"insert":"添加企业成员"},{"insert":"。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"访客加入组织后，组织角色只能是访客。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"2TogSUFtr5","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"2TogSUFtr5":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"每次请求只能添加一位成员。如需添加多位，请依次发送请求。\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"该 API 不支持并发请求。\n"}],"zoneId":"2TogSUFtr5","zoneType":"Z"}}
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="organizationPeople"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIBatchAddOrganizationPeopleResponse> OpenAPIBatchAddOrganizationPeopleAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::G.PropertiesOrganizationPeopleItems> organizationPeople,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.OpenAPIBatchAddOrganizationPeopleRequest
            {
                OrganizationPeople = organizationPeople,
            };

            return await OpenAPIBatchAddOrganizationPeopleAsync(
                organizationId: organizationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}