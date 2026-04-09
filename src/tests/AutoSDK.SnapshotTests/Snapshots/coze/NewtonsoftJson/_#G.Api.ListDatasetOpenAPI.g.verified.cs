//HintName: G.Api.ListDatasetOpenAPI.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListDatasetOpenAPISecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListDatasetOpenAPISecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListDatasetOpenAPISecurityRequirement0,
            };
        partial void PrepareListDatasetOpenAPIArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string spaceId,
            ref string? name,
            ref int? formatType,
            ref int? pageNum,
            ref int? pageSize);
        partial void PrepareListDatasetOpenAPIRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string spaceId,
            string? name,
            int? formatType,
            int? pageNum,
            int? pageSize);
        partial void ProcessListDatasetOpenAPIResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDatasetOpenAPIResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查看知识库列表<br/>
        /// {"0":{"ops":[{"insert":"调用此接口查看指定空间资源库下的全部知识库。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此接口可查看工作空间下，空间资源库中的全部知识库，包括扣子知识库和火山知识库，无论知识库是否归本人所有。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"Nmd2TWIy1I","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"Nmd2TWIy1I":{"ops":[{"attributes":{"list":"bullet1","lmkr":"1"},"insert":"*"},{"insert":"暂不支持通过 API 查看扣子应用中的知识库。\n"},{"attributes":{"lmkr":"1","list":"bullet1"},"insert":"*"},{"insert":"暂不支持通过该 API 查看火山知识库中的文件列表等详细信息。\n"}],"zoneId":"Nmd2TWIy1I","zoneType":"Z"}}
        /// </summary>
        /// <param name="spaceId"></param>
        /// <param name="name"></param>
        /// <param name="formatType"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListDatasetOpenAPIResponse> ListDatasetOpenAPIAsync(
            string spaceId,
            string? name = default,
            int? formatType = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListDatasetOpenAPIArguments(
                httpClient: HttpClient,
                spaceId: ref spaceId,
                name: ref name,
                formatType: ref formatType,
                pageNum: ref pageNum,
                pageSize: ref pageSize);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListDatasetOpenAPISecurityRequirements,
                operationName: "ListDatasetOpenAPIAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("space_id", spaceId)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("format_type", formatType?.ToString())
                .AddOptionalParameter("page_num", pageNum?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListDatasetOpenAPIRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                spaceId: spaceId,
                name: name,
                formatType: formatType,
                pageNum: pageNum,
                pageSize: pageSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListDatasetOpenAPIResponse(
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
                ProcessListDatasetOpenAPIResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListDatasetOpenAPIResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListDatasetOpenAPIResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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