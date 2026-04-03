//HintName: G.CallsClient.CallsQueryStreamCallsStreamQueryPost.g.cs

#nullable enable

namespace G
{
    public partial class CallsClient
    {
        partial void PrepareCallsQueryStreamCallsStreamQueryPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? accept,
            global::G.CallsQueryReq request);
        partial void PrepareCallsQueryStreamCallsStreamQueryPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? accept,
            global::G.CallsQueryReq request);
        partial void ProcessCallsQueryStreamCallsStreamQueryPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCallsQueryStreamCallsStreamQueryPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Calls Query Stream
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/jsonl
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> CallsQueryStreamCallsStreamQueryPostAsync(

            global::G.CallsQueryReq request,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCallsQueryStreamCallsStreamQueryPostArguments(
                httpClient: HttpClient,
                accept: ref accept,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/calls/stream_query",
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

            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("accept", accept.ToString());
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
            PrepareCallsQueryStreamCallsStreamQueryPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                accept: accept,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCallsQueryStreamCallsStreamQueryPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessCallsQueryStreamCallsStreamQueryPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Calls Query Stream
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/jsonl
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="sortBy"></param>
        /// <param name="query"></param>
        /// <param name="includeCosts">
        /// Beta, subject to change. If true, the response will include any model costs for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFeedback">
        /// Beta, subject to change. If true, the response will include feedback for each call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// Beta, subject to change. If true, the response will include the storage size for a call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTotalStorageSize">
        /// Beta, subject to change. If true, the response will include the total storage size for a trace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeUsernames">
        /// If true, the response will attempt to resolve each call's wb_user_id to a username for the duration of this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="columns"></param>
        /// <param name="expandColumns">
        /// Columns to expand, i.e. refs to other objects
        /// </param>
        /// <param name="returnExpandedColumnValues">
        /// If true, the response will include raw values for expanded columns. If false, the response expand_columns will only be used for filtering and ordering. This is useful for clients that want to resolve refs themselves, e.g. for performance reasons.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CallsQueryStreamCallsStreamQueryPostAsync(
            string projectId,
            string? accept = default,
            global::G.CallsFilter? filter = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy = default,
            global::G.Query? query = default,
            bool? includeCosts = default,
            bool? includeFeedback = default,
            bool? includeStorageSize = default,
            bool? includeTotalStorageSize = default,
            bool? includeUsernames = default,
            global::System.Collections.Generic.IList<string>? columns = default,
            global::System.Collections.Generic.IList<string>? expandColumns = default,
            bool? returnExpandedColumnValues = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CallsQueryReq
            {
                ProjectId = projectId,
                Filter = filter,
                Limit = limit,
                Offset = offset,
                SortBy = sortBy,
                Query = query,
                IncludeCosts = includeCosts,
                IncludeFeedback = includeFeedback,
                IncludeStorageSize = includeStorageSize,
                IncludeTotalStorageSize = includeTotalStorageSize,
                IncludeUsernames = includeUsernames,
                Columns = columns,
                ExpandColumns = expandColumns,
                ReturnExpandedColumnValues = returnExpandedColumnValues,
            };

            return await CallsQueryStreamCallsStreamQueryPostAsync(
                accept: accept,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}