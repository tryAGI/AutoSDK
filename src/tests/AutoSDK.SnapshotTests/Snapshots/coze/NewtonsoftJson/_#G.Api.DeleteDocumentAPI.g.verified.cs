//HintName: G.Api.DeleteDocumentAPI.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_DeleteDocumentAPISecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_DeleteDocumentAPISecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_DeleteDocumentAPISecurityRequirement0,
            };
        partial void PrepareDeleteDocumentAPIArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.DeleteDocumentAPIAgwJsConv agwJsConv,
            global::G.DeleteDocumentAPIRequest request);
        partial void PrepareDeleteDocumentAPIRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.DeleteDocumentAPIAgwJsConv agwJsConv,
            global::G.DeleteDocumentAPIRequest request);
        partial void ProcessDeleteDocumentAPIResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteDocumentAPIResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 删除知识库文件<br/>
        /// 调用此接口删除扣子知识库中的文本、图片、表格等文件，支持批量删除。<br/>
        /// * 仅知识库的所有者可以删除知识库文件。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于删除扣子知识库中的文件，不支持删除火山知识库中的文件，如果需要删除火山知识库中的文件，请参见[删除火山知识库文件](https://www.volcengine.com/docs/84313/1254608)。
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteDocumentAPIResponse> DeleteDocumentAPIAsync(
            global::G.DeleteDocumentAPIAgwJsConv agwJsConv,

            global::G.DeleteDocumentAPIRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeleteDocumentAPIArguments(
                httpClient: HttpClient,
                agwJsConv: ref agwJsConv,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DeleteDocumentAPISecurityRequirements,
                operationName: "DeleteDocumentAPIAsync");

            var agwJsConvValue = agwJsConv switch
            {
                global::G.DeleteDocumentAPIAgwJsConv.Str => "str",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/open_api/knowledge/document/delete",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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

            __httpRequest.Headers.TryAddWithoutValidation("Agw-Js-Conv", agwJsConv.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeleteDocumentAPIRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agwJsConv: agwJsConv,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteDocumentAPIResponse(
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
                ProcessDeleteDocumentAPIResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.DeleteDocumentAPIResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.DeleteDocumentAPIResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// 删除知识库文件<br/>
        /// 调用此接口删除扣子知识库中的文本、图片、表格等文件，支持批量删除。<br/>
        /// * 仅知识库的所有者可以删除知识库文件。<br/>
        /// * 知识库分为扣子知识库和火山知识库，该 API 仅用于删除扣子知识库中的文件，不支持删除火山知识库中的文件，如果需要删除火山知识库中的文件，请参见[删除火山知识库文件](https://www.volcengine.com/docs/84313/1254608)。
        /// </summary>
        /// <param name="agwJsConv"></param>
        /// <param name="documentIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DeleteDocumentAPIResponse> DeleteDocumentAPIAsync(
            global::G.DeleteDocumentAPIAgwJsConv agwJsConv,
            global::System.Collections.Generic.IList<string> documentIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.DeleteDocumentAPIRequest
            {
                DocumentIds = documentIds,
            };

            return await DeleteDocumentAPIAsync(
                agwJsConv: agwJsConv,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}