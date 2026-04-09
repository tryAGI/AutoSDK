//HintName: G.Api.OpenAPIBindConnectorUserConfig.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_OpenAPIBindConnectorUserConfigSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_OpenAPIBindConnectorUserConfigSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_OpenAPIBindConnectorUserConfigSecurityRequirement0,
            };
        partial void PrepareOpenAPIBindConnectorUserConfigArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string connectorId,
            global::G.OpenAPIBindConnectorUserConfigRequest request);
        partial void PrepareOpenAPIBindConnectorUserConfigRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string connectorId,
            global::G.OpenAPIBindConnectorUserConfigRequest request);
        partial void ProcessOpenAPIBindConnectorUserConfigResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIBindConnectorUserConfigResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 绑定设备<br/>
        /// {"0":{"ops":[{"insert":"将设备与自定义渠道绑定。\n"},{"attributes":{"anchor":"64fdb87a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"硬件厂商可以调用本 API 将企业内的硬件设备与企业的自定义渠道绑定，当开发者发布智能体到该自定义渠道时，在发布配置页面的设备列表中选择对应的设备，即可快速发布到对应设备。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"支持批量绑定多台设备。\n"},{"attributes":{"zoneId":"DVGaiNBO1Q","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"DVGaiNBO1Q":{"ops":[{"insert":"创建自定义渠道后，默认未开启 API 绑定设备的能力，如果需要调用本 API，你需要将自定义渠道的渠道 ID 提供给扣子商务经理，申请开通渠道设备绑定的能力，并由商务经理配置设备绑定的 key。\n"}],"zoneId":"DVGaiNBO1Q","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIBindConnectorUserConfigResponse> OpenAPIBindConnectorUserConfigAsync(
            string connectorId,

            global::G.OpenAPIBindConnectorUserConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIBindConnectorUserConfigArguments(
                httpClient: HttpClient,
                connectorId: ref connectorId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_OpenAPIBindConnectorUserConfigSecurityRequirements,
                operationName: "OpenAPIBindConnectorUserConfigAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/connectors/{connectorId}/user_configs",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareOpenAPIBindConnectorUserConfigRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                connectorId: connectorId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIBindConnectorUserConfigResponse(
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
                ProcessOpenAPIBindConnectorUserConfigResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIBindConnectorUserConfigResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIBindConnectorUserConfigResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 绑定设备<br/>
        /// {"0":{"ops":[{"insert":"将设备与自定义渠道绑定。\n"},{"attributes":{"anchor":"64fdb87a","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"硬件厂商可以调用本 API 将企业内的硬件设备与企业的自定义渠道绑定，当开发者发布智能体到该自定义渠道时，在发布配置页面的设备列表中选择对应的设备，即可快速发布到对应设备。\n"},{"attributes":{"lmkr":"1","start":"1","origin-start":"1","ol-id":"spQ23ygY"},"insert":"*"},{"insert":"支持批量绑定多台设备。\n"},{"attributes":{"zoneId":"DVGaiNBO1Q","zoneType":"Z","type":"tip","title":"说明","border":"#bacefd","background":"#f0f4ff","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"DVGaiNBO1Q":{"ops":[{"insert":"创建自定义渠道后，默认未开启 API 绑定设备的能力，如果需要调用本 API，你需要将自定义渠道的渠道 ID 提供给扣子商务经理，申请开通渠道设备绑定的能力，并由商务经理配置设备绑定的 key。\n"}],"zoneId":"DVGaiNBO1Q","zoneType":"Z"}}
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="configs"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIBindConnectorUserConfigResponse> OpenAPIBindConnectorUserConfigAsync(
            string connectorId,
            global::System.Collections.Generic.IList<global::G.UserConfig> configs,
            string? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OpenAPIBindConnectorUserConfigRequest
            {
                Configs = configs,
                UserId = userId,
            };

            return await OpenAPIBindConnectorUserConfigAsync(
                connectorId: connectorId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}