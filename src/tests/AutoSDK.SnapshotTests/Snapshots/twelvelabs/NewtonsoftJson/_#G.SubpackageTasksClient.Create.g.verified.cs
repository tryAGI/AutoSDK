//HintName: G.SubpackageTasksClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageTasksClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::G.CreateRequest3 request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::G.CreateRequest3 request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a video indexing task<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Warning title="Legacy endpoint"&gt;<br/>
        /// This endpoint bundles two operations (upload and indexing) together. In the next major API release, this endpoint will be removed in favor of a separated workflow:<br/>
        /// 1. Upload your video using the [`POST /assets`](/v1.3/api-reference/upload-content/direct-uploads/create) endpoint<br/>
        /// 2. Index the uploaded video using the [`POST /indexes/{index-id}/indexed-assets`](/v1.3/api-reference/index-content/create) endpoint<br/>
        /// This separation provides better control, reusability of assets, and improved error handling. New implementations should use the new workflow.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TasksCreateResponse200> CreateAsync(
            string xApiKey,

            global::G.CreateRequest3 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);

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
                                path: "/tasks",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{xApiKey}"),
                                name: "\"x-api-key\"");
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{request.IndexId}"),
                                name: "\"index_id\"");
                            if (request.VideoFile != default)
                            {

                                var __contentVideoFile = new global::System.Net.Http.ByteArrayContent(request.VideoFile ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentVideoFile,
                                    name: "\"video_file\"",
                                    fileName: request.VideoFilename != null ? $"\"{request.VideoFilename}\"" : string.Empty);
                                if (__contentVideoFile.Headers.ContentDisposition != null)
                                {
                                    __contentVideoFile.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.VideoUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.VideoUrl}"),
                                    name: "\"video_url\"");
                            } 
                            if (request.EnableVideoStream != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.EnableVideoStream}"),
                                    name: "\"enable_video_stream\"");
                            } 
                            if (request.UserMetadata != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.UserMetadata}"),
                                    name: "\"user_metadata\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xApiKey: xApiKey,
                    request: request);

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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // The request has failed.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::G.CreateVideoIndexingTaskRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::G.CreateVideoIndexingTaskRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::G.CreateVideoIndexingTaskRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::G.ApiException<global::G.CreateVideoIndexingTaskRequestBadRequestError>(
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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.TasksCreateResponse200.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.TasksCreateResponse200.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a video indexing task<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Warning title="Legacy endpoint"&gt;<br/>
        /// This endpoint bundles two operations (upload and indexing) together. In the next major API release, this endpoint will be removed in favor of a separated workflow:<br/>
        /// 1. Upload your video using the [`POST /assets`](/v1.3/api-reference/upload-content/direct-uploads/create) endpoint<br/>
        /// 2. Index the uploaded video using the [`POST /indexes/{index-id}/indexed-assets`](/v1.3/api-reference/index-content/create) endpoint<br/>
        /// This separation provides better control, reusability of assets, and improved error handling. New implementations should use the new workflow.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="indexId">
        /// The unique identifier of the index to which the video is being uploaded.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/videos/{video-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TasksCreateResponse200> CreateAsync(
            string xApiKey,
            string indexId,
            byte[]? videoFile = default,
            string? videoFilename = default,
            string? videoUrl = default,
            bool? enableVideoStream = default,
            string? userMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateRequest3
            {
                IndexId = indexId,
                VideoFile = videoFile,
                VideoFilename = videoFilename,
                VideoUrl = videoUrl,
                EnableVideoStream = enableVideoStream,
                UserMetadata = userMetadata,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}