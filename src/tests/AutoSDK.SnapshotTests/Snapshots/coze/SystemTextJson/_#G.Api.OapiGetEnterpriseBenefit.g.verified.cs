//HintName: G.Api.OapiGetEnterpriseBenefit.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OapiGetEnterpriseBenefitSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_OapiGetEnterpriseBenefitSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OapiGetEnterpriseBenefitSecurityRequirement0,
            };
        partial void PrepareOapiGetEnterpriseBenefitArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? benefitTypeList,
            ref string? resourceId);
        partial void PrepareOapiGetEnterpriseBenefitRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? benefitTypeList,
            string? resourceId);
        partial void ProcessOapiGetEnterpriseBenefitResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOapiGetEnterpriseBenefitResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查询套餐权益<br/>
        /// {"0":{"ops":[{"insert":"查询当前账号的套餐权益信息。\n"},{"attributes":{"anchor":"9dbdec35","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以通过本 API 查询当前账号的以下套餐权益信息：\n"},{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"所属的套餐类型。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"扩容管理页面中 API 扩容的信息，包括套餐默认的 API QPS、扩容新增的 API QPS 额度，以及当前实际生效的 API QPS 额度。\n"},{"attributes":{"list":"indent1","text-indent":"true","lmkr":"1"},"insert":"*"},{"attributes":{"width":"400","height":"141.13924050632912","scale":"0.3528481012658228","image":"true","isPlugin":"true","uuid":"MaMnK43a","src":"https://p9-arcosite.byteimg.com/obj/tos-cn-i-goo7wpa0wc/720efb1da1e54938ae626248aebd08c3","loadingStatus":"success"},"insert":" "},{"insert":"\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"套餐权益内通过 MCP 方式调用付费插件的次数限制。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="benefitTypeList"></param>
        /// <param name="resourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OapiGetEnterpriseBenefitResponse> OapiGetEnterpriseBenefitAsync(
            global::System.Collections.Generic.IList<string>? benefitTypeList = default,
            string? resourceId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOapiGetEnterpriseBenefitArguments(
                httpClient: HttpClient,
                benefitTypeList: benefitTypeList,
                resourceId: ref resourceId);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OapiGetEnterpriseBenefitSecurityRequirements,
                operationName: "OapiGetEnterpriseBenefitAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/commerce/benefit/benefits/get",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("benefit_type_list", benefitTypeList, delimiter: ",", explode: true)
                .AddOptionalParameter("resource_id", resourceId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOapiGetEnterpriseBenefitRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                benefitTypeList: benefitTypeList,
                resourceId: resourceId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOapiGetEnterpriseBenefitResponse(
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
                ProcessOapiGetEnterpriseBenefitResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OapiGetEnterpriseBenefitResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OapiGetEnterpriseBenefitResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}