//HintName: G.Api.StreamOrQueue.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {

        /// <summary>
        /// A successful outcome selected by the actual HTTP status and media type.
        /// Dispose this result after consuming its binary body to release the HTTP response.
        /// </summary>
        public sealed class StreamOrQueueResult : global::G.AutoSDKHttpResponse, global::System.IDisposable
        {
            internal StreamOrQueueResult(
                global::System.Net.HttpStatusCode statusCode,
                global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers,
                global::System.Uri? requestUri,
                global::System.IO.Stream? body0 = default,
                global::G.StreamOrQueueResponse? body1 = default)
                : base(statusCode, headers, requestUri)
            {
                Body200 = body0;
                Body202 = body1;
            }
            /// <summary>Gets the body for HTTP 200; null for other outcomes.</summary>
            public global::System.IO.Stream? Body200 { get; }
            /// <summary>Gets the body for HTTP 202; null for other outcomes.</summary>
            public global::G.StreamOrQueueResponse? Body202 { get; }
            /// <summary>Releases the binary response stream, if present.</summary>
            public void Dispose()
            {
                Body200?.Dispose();
            }
        }
        partial void PrepareStreamOrQueueArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareStreamOrQueueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessStreamOrQueueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStreamOrQueueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Api.StreamOrQueueResult> StreamOrQueueAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await StreamOrQueueAsResponseAsync(
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.Api.StreamOrQueueResult>> StreamOrQueueAsResponseAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStreamOrQueueArguments(
                httpClient: HttpClient);

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/mixed",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStreamOrQueueRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamOrQueue",
                                methodName: "StreamOrQueueAsync",
                                pathTemplate: "\"/mixed\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamOrQueue",
                                methodName: "StreamOrQueueAsync",
                                pathTemplate: "\"/mixed\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamOrQueue",
                                methodName: "StreamOrQueueAsync",
                                pathTemplate: "\"/mixed\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                try
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessStreamOrQueueResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamOrQueue",
                                methodName: "StreamOrQueueAsync",
                                pathTemplate: "\"/mixed\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StreamOrQueue",
                                methodName: "StreamOrQueueAsync",
                                pathTemplate: "\"/mixed\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (!__response.IsSuccessStatusCode)
                            {
                                var __errorContent = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                throw global::G.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __errorContent,
                                    innerException: null,
                                    responseBody: __errorContent,
                                    responseHeaders: global::G.AutoSDKHttpResponse.CreateHeaders(__response));
                            }
                            var __mediaType = __response.Content.Headers.ContentType?.MediaType;

                            if (((int)__response.StatusCode == 200) && (global::System.String.Equals(__mediaType, "audio/wav", global::System.StringComparison.OrdinalIgnoreCase) || global::System.String.Equals(__mediaType, "audio/ogg", global::System.StringComparison.OrdinalIgnoreCase)))
                            {
                                var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                var __body = new global::G.ResponseStream(__response, __stream);
                                var __result = new global::G.Api.StreamOrQueueResult(
                                    statusCode: __response.StatusCode,
                                    headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                    requestUri: __response.RequestMessage?.RequestUri,
                                    body0: __body);
                                return new global::G.AutoSDKHttpResponse<global::G.Api.StreamOrQueueResult>(
                                    statusCode: __result.StatusCode,
                                    headers: __result.Headers,
                                    requestUri: __result.RequestUri,
                                    body: __result);
                            }

                            if (((int)__response.StatusCode == 202) && (global::System.String.Equals(__mediaType, "application/json", global::System.StringComparison.OrdinalIgnoreCase)))
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);
                                var __body = global::G.StreamOrQueueResponse.FromJson(__content, JsonSerializerOptions) ?? throw new global::System.InvalidOperationException("Response deserialization failed.");
                                var __result = new global::G.Api.StreamOrQueueResult(
                                    statusCode: __response.StatusCode,
                                    headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                    requestUri: __response.RequestMessage?.RequestUri,
                                    body1: __body);
                                __response.Dispose();
                                return new global::G.AutoSDKHttpResponse<global::G.Api.StreamOrQueueResult>(
                                    statusCode: __result.StatusCode,
                                    headers: __result.Headers,
                                    requestUri: __result.RequestUri,
                                    body: __result);
                            }

                            throw global::G.ApiException.Create(
                                statusCode: __response.StatusCode,
                                message: "The successful HTTP status and Content-Type do not match a declared response contract.",
                                innerException: null,
                                responseBody: null,
                                responseHeaders: global::G.AutoSDKHttpResponse.CreateHeaders(__response));


                }
                catch
                {
                    __response.Dispose();
                    throw;
                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}