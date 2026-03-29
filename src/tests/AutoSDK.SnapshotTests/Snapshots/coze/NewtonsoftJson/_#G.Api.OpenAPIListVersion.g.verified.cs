//HintName: G.Api.OpenAPIListVersion.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareOpenAPIListVersionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PublishStatus? publishStatus,
            ref int? pageSize,
            ref string? pageToken,
            ref bool? includeInputOutput,
            ref string workflowId);
        partial void PrepareOpenAPIListVersionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PublishStatus? publishStatus,
            int? pageSize,
            string? pageToken,
            bool? includeInputOutput,
            string workflowId);
        partial void ProcessOpenAPIListVersionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenAPIListVersionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 查询工作流的版本列表<br/>
        /// {"0":{"ops":[{"insert":"查询工作流的版本列表。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以通过本 API 查询某个工作流的所有历史版本记录，包括版本号、版本描述、操作者和发布时间等。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="publishStatus"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="includeInputOutput"></param>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OpenAPIListVersionResponse> OpenAPIListVersionAsync(
            string workflowId,
            global::G.PublishStatus? publishStatus = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeInputOutput = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOpenAPIListVersionArguments(
                httpClient: HttpClient,
                publishStatus: ref publishStatus,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                includeInputOutput: ref includeInputOutput,
                workflowId: ref workflowId);

            var publishStatusValue = publishStatus switch
            {
                global::G.PublishStatus.All => "all",
                global::G.PublishStatus.PublishedOnline => "published_online",
                global::G.PublishStatus.PublishedDraft => "published_draft",
                global::G.PublishStatus.UnpublishedDraft => "unpublished_draft",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/workflows/{workflowId}/versions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("publish_status", publishStatus?.ToValueString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("page_token", pageToken)
                .AddOptionalParameter("include_input_output", includeInputOutput?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOpenAPIListVersionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                publishStatus: publishStatus,
                pageSize: pageSize,
                pageToken: pageToken,
                includeInputOutput: includeInputOutput,
                workflowId: workflowId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOpenAPIListVersionResponse(
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
                ProcessOpenAPIListVersionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.OpenAPIListVersionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.OpenAPIListVersionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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