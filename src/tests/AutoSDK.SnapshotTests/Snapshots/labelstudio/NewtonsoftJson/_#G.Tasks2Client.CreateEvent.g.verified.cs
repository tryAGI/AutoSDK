//HintName: G.Tasks2Client.CreateEvent.g.cs

#nullable enable

namespace G
{
    public partial class Tasks2Client
    {
        partial void PrepareCreateEventArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::G.TaskEventRequest request);
        partial void PrepareCreateEventRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::G.TaskEventRequest request);
        partial void ProcessCreateEventResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEventResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create task event<br/>
        ///     Create a new task event to track user interactions and system events during annotation.<br/>
        ///     This endpoint is designed to receive events from the frontend labeling interface to enable<br/>
        ///     accurate lead time calculation and detailed annotation analytics.<br/>
        ///     ## Event Types<br/>
        ///     **Core Annotation Events:**<br/>
        ///     - `annotation_loaded` - When annotation interface is loaded<br/>
        ///     - `annotation_created` - When annotation is submitted<br/>
        ///     - `annotation_updated` - When annotation is modified<br/>
        ///     - `annotation_reviewed` - When annotation is reviewed<br/>
        ///     **User Activity Events:**<br/>
        ///     - `visibility_change` - When page visibility changes (tab switch, minimize)<br/>
        ///     - `idle_detected` - When user goes idle<br/>
        ///     - `idle_resumed` - When user returns from idle<br/>
        ///     **Interaction Events:**<br/>
        ///     - `region_finished_drawing` - When annotation region is completed<br/>
        ///     - `region_deleted` - When annotation regions are removed<br/>
        ///     - `hotkey_pressed` - When keyboard shortcuts are used<br/>
        ///     **Media Events:**<br/>
        ///     - `video_playback_start/end` - Video playback control<br/>
        ///     - `audio_playback_start/end` - Audio playback control<br/>
        ///     - `video_scrub` - Video timeline scrubbing<br/>
        ///     ## Usage<br/>
        ///     Events are automatically associated with the task specified in the URL path.<br/>
        ///     The current user is automatically set as the actor. Project and organization<br/>
        ///     are derived from the task context.<br/>
        ///     ## Example Request<br/>
        ///     ```json<br/>
        ///     {<br/>
        ///         "event_key": "annotation_loaded",<br/>
        ///         "event_time": "2024-01-15T10:30:00Z",<br/>
        ///         "annotation": 123,<br/>
        ///         "meta": {<br/>
        ///             "annotation_count": 5,<br/>
        ///             "estimated_time": 300<br/>
        ///         }<br/>
        ///     }<br/>
        ///     ```<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TaskEvent> CreateEventAsync(
            int id,

            global::G.TaskEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateEventArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/tasks/{id}/events/",
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
            PrepareCreateEventRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateEventResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
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
                ProcessCreateEventResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TaskEvent.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TaskEvent.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create task event<br/>
        ///     Create a new task event to track user interactions and system events during annotation.<br/>
        ///     This endpoint is designed to receive events from the frontend labeling interface to enable<br/>
        ///     accurate lead time calculation and detailed annotation analytics.<br/>
        ///     ## Event Types<br/>
        ///     **Core Annotation Events:**<br/>
        ///     - `annotation_loaded` - When annotation interface is loaded<br/>
        ///     - `annotation_created` - When annotation is submitted<br/>
        ///     - `annotation_updated` - When annotation is modified<br/>
        ///     - `annotation_reviewed` - When annotation is reviewed<br/>
        ///     **User Activity Events:**<br/>
        ///     - `visibility_change` - When page visibility changes (tab switch, minimize)<br/>
        ///     - `idle_detected` - When user goes idle<br/>
        ///     - `idle_resumed` - When user returns from idle<br/>
        ///     **Interaction Events:**<br/>
        ///     - `region_finished_drawing` - When annotation region is completed<br/>
        ///     - `region_deleted` - When annotation regions are removed<br/>
        ///     - `hotkey_pressed` - When keyboard shortcuts are used<br/>
        ///     **Media Events:**<br/>
        ///     - `video_playback_start/end` - Video playback control<br/>
        ///     - `audio_playback_start/end` - Audio playback control<br/>
        ///     - `video_scrub` - Video timeline scrubbing<br/>
        ///     ## Usage<br/>
        ///     Events are automatically associated with the task specified in the URL path.<br/>
        ///     The current user is automatically set as the actor. Project and organization<br/>
        ///     are derived from the task context.<br/>
        ///     ## Example Request<br/>
        ///     ```json<br/>
        ///     {<br/>
        ///         "event_key": "annotation_loaded",<br/>
        ///         "event_time": "2024-01-15T10:30:00Z",<br/>
        ///         "annotation": 123,<br/>
        ///         "meta": {<br/>
        ///             "annotation_count": 5,<br/>
        ///             "estimated_time": 300<br/>
        ///         }<br/>
        ///     }<br/>
        ///     ```<br/>
        ///     
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotation">
        /// Annotation ID associated with this event
        /// </param>
        /// <param name="annotationDraftId">
        /// Draft annotation ID associated with this event
        /// </param>
        /// <param name="eventKey">
        /// Event type identifier (e.g., "annotation_loaded", "region_finished_drawing")
        /// </param>
        /// <param name="eventTime">
        /// Timestamp when the event occurred (frontend time)
        /// </param>
        /// <param name="meta">
        /// Additional event metadata (region data, hotkey info, etc.)
        /// </param>
        /// <param name="review">
        /// Review ID associated with this event
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TaskEvent> CreateEventAsync(
            int id,
            string eventKey,
            global::System.DateTime eventTime,
            int? annotation = default,
            int? annotationDraftId = default,
            object? meta = default,
            int? review = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TaskEventRequest
            {
                Annotation = annotation,
                AnnotationDraftId = annotationDraftId,
                EventKey = eventKey,
                EventTime = eventTime,
                Meta = meta,
                Review = review,
            };

            return await CreateEventAsync(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}