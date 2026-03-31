//HintName: G.Api.CreateKnowledgeBase.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateKnowledgeBaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.KnowledgeBaseRequest request);
        partial void PrepareCreateKnowledgeBaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.KnowledgeBaseRequest request);
        partial void ProcessCreateKnowledgeBaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateKnowledgeBaseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new knowledge base
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> CreateKnowledgeBaseAsync(

            global::G.KnowledgeBaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateKnowledgeBaseArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/create-knowledge-base",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.KnowledgeBaseName}"),
                name: "\"knowledge_base_name\"");
            if (request.KnowledgeBaseTexts != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.KnowledgeBaseTexts, x => x))}]"),
                    name: "\"knowledge_base_texts\"");
            } 
            if (request.KnowledgeBaseFiles != default)
            {

                for (var __iKnowledgeBaseFiles = 0; __iKnowledgeBaseFiles < request.KnowledgeBaseFiles.Count; __iKnowledgeBaseFiles++)
                {
                    var __contentKnowledgeBaseFiles = new global::System.Net.Http.ByteArrayContent(request.KnowledgeBaseFiles[__iKnowledgeBaseFiles]);
                    __httpRequestContent.Add(
                        content: __contentKnowledgeBaseFiles,
                        name: "\"knowledge_base_files\"",
                        fileName: $"\"file{__iKnowledgeBaseFiles}.bin\"");
                    if (__contentKnowledgeBaseFiles.Headers.ContentDisposition != null)
                    {
                        __contentKnowledgeBaseFiles.Headers.ContentDisposition.FileNameStar = null;
                    }
                }
            } 
            if (request.KnowledgeBaseUrls != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.KnowledgeBaseUrls, x => x))}]"),
                    name: "\"knowledge_base_urls\"");
            } 
            if (request.EnableAutoRefresh != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EnableAutoRefresh}"),
                    name: "\"enable_auto_refresh\"");
            } 
            if (request.MaxChunkSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MaxChunkSize}"),
                    name: "\"max_chunk_size\"");
            } 
            if (request.MinChunkSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MinChunkSize}"),
                    name: "\"min_chunk_size\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateKnowledgeBaseRequest(
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
            ProcessCreateKnowledgeBaseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateKnowledgeBaseResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateKnowledgeBaseResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateKnowledgeBaseResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateKnowledgeBaseResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateKnowledgeBaseResponse2? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateKnowledgeBaseResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateKnowledgeBaseResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateKnowledgeBaseResponse2>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Payment Required
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.CreateKnowledgeBaseResponse3? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.CreateKnowledgeBaseResponse3.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.CreateKnowledgeBaseResponse3.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateKnowledgeBaseResponse3>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too Many Requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.CreateKnowledgeBaseResponse4? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.CreateKnowledgeBaseResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.CreateKnowledgeBaseResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateKnowledgeBaseResponse4>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.CreateKnowledgeBaseResponse5? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.CreateKnowledgeBaseResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.CreateKnowledgeBaseResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateKnowledgeBaseResponse5>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessCreateKnowledgeBaseResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.KnowledgeBaseResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.KnowledgeBaseResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a new knowledge base
        /// </summary>
        /// <param name="knowledgeBaseName">
        /// Name of the knowledge base. Must be less than 40 characters.<br/>
        /// Example: Sample KB
        /// </param>
        /// <param name="knowledgeBaseTexts">
        /// Texts to add to the knowledge base.
        /// </param>
        /// <param name="knowledgeBaseFiles">
        /// Files to add to the knowledge base. Limit to 25 files, where each file is limited to 50MB.
        /// </param>
        /// <param name="knowledgeBaseUrls">
        /// URLs to be scraped and added to the knowledge base. Must be valid urls.<br/>
        /// Example: [https://www.example.com, https://www.retellai.com]
        /// </param>
        /// <param name="enableAutoRefresh">
        /// Whether to enable auto refresh for the knowledge base urls. If set to true, will retrieve the data from the specified url every 12 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxChunkSize">
        /// Maximum number of characters per chunk when splitting knowledge base. Default is 2000. content. Immutable after creation.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="minChunkSize">
        /// Minimum number of characters per chunk. Chunks smaller than this will be merged with adjacent chunks. Must be less than max_chunk_size. Immutable after creation. Default is 400.<br/>
        /// Example: 400
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.KnowledgeBaseResponse> CreateKnowledgeBaseAsync(
            string knowledgeBaseName,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseRequestKnowledgeBaseText>? knowledgeBaseTexts = default,
            global::System.Collections.Generic.IList<byte[]>? knowledgeBaseFiles = default,
            global::System.Collections.Generic.IList<string>? knowledgeBaseUrls = default,
            bool? enableAutoRefresh = default,
            int? maxChunkSize = default,
            int? minChunkSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.KnowledgeBaseRequest
            {
                KnowledgeBaseName = knowledgeBaseName,
                KnowledgeBaseTexts = knowledgeBaseTexts,
                KnowledgeBaseFiles = knowledgeBaseFiles,
                KnowledgeBaseUrls = knowledgeBaseUrls,
                EnableAutoRefresh = enableAutoRefresh,
                MaxChunkSize = maxChunkSize,
                MinChunkSize = minChunkSize,
            };

            return await CreateKnowledgeBaseAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}