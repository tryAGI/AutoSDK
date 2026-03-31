//HintName: G.TalksStreamsClient.CreateTalkStream.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class TalksStreamsClient
    {
        partial void PrepareCreateTalkStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string? xApiKeyExternal,
            ref string? cookie,
            global::G.CreateTalkStreamRequest2 request);
        partial void PrepareCreateTalkStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string? xApiKeyExternal,
            string? cookie,
            global::G.CreateTalkStreamRequest2 request);
        partial void ProcessCreateTalkStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTalkStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="cookie"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.CreateTalkStreamResponse> CreateTalkStreamAsync(
            string id,

            global::G.CreateTalkStreamRequest2 request,
            string? xApiKeyExternal = default,
            string? cookie = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTalkStreamArguments(
                httpClient: HttpClient,
                id: ref id,
                xApiKeyExternal: ref xApiKeyExternal,
                cookie: ref cookie,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/talks/streams/{id}",
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

            if (xApiKeyExternal != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-api-key-external", xApiKeyExternal.ToString());
            }
            if (cookie != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("cookie", cookie.ToString());
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
            PrepareCreateTalkStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                xApiKeyExternal: xApiKeyExternal,
                cookie: cookie,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTalkStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // SessionError
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.CreateTalkStreamResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.CreateTalkStreamResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.CreateTalkStreamResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateTalkStreamResponse2>(
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
            // AuthorizationError
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.CreateTalkStreamResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.CreateTalkStreamResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.CreateTalkStreamResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.CreateTalkStreamResponse3>(
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
                ProcessCreateTalkStreamResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateTalkStreamResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateTalkStreamResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a talk stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xApiKeyExternal"></param>
        /// <param name="cookie"></param>
        /// <param name="sessionId"></param>
        /// <param name="script"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the talk response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the talk video
        /// </param>
        /// <param name="audioOptimization">
        /// The optimization level of the audio<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="metadata">
        /// Metadata passed to the talks worker
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.CreateTalkStreamResponse> CreateTalkStreamAsync(
            string id,
            global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant12, global::G.CreateTalkStreamRequestScriptVariant22> script,
            string? xApiKeyExternal = default,
            string? cookie = default,
            string? sessionId = default,
            global::G.AllOf<global::G.CreateTalkStreamRequestConfigVariant12, global::G.CreateTalkStreamRequestConfigVariant22>? config = default,
            string? userData = default,
            string? name = default,
            double? audioOptimization = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CreateTalkStreamRequest2
            {
                SessionId = sessionId,
                Script = script,
                Config = config,
                UserData = userData,
                Name = name,
                AudioOptimization = audioOptimization,
                Metadata = metadata,
            };

            return await CreateTalkStreamAsync(
                id: id,
                xApiKeyExternal: xApiKeyExternal,
                cookie: cookie,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}