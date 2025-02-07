//HintName: G.PublicClient.ReadSharedFeedbacks.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedFeedbacksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::G.SourceType>? source,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            ref bool? hasComment,
            ref bool? hasScore,
            ref global::G.FeedbackLevel? level);
        partial void PrepareReadSharedFeedbacksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run,
            global::System.Collections.Generic.IList<string>? key,
            global::System.Collections.Generic.IList<global::System.Guid>? session,
            global::System.Collections.Generic.IList<global::G.SourceType>? source,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::System.Guid>? user,
            bool? hasComment,
            bool? hasScore,
            global::G.FeedbackLevel? level);
        partial void ProcessReadSharedFeedbacksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedFeedbacksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Feedbacks
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level">
        /// Enum for feedback levels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadSharedFeedbacksAsync(
            global::System.Guid shareToken,
            global::System.Collections.Generic.IList<global::System.Guid>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::System.Collections.Generic.IList<global::System.Guid>? session = default,
            global::System.Collections.Generic.IList<global::G.SourceType>? source = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::G.FeedbackLevel? level = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadSharedFeedbacksArguments(
                httpClient: HttpClient,
                shareToken: ref shareToken,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: ref limit,
                offset: ref offset,
                user: user,
                hasComment: ref hasComment,
                hasScore: ref hasScore,
                level: ref level);

            var levelValue = level switch
            {
                global::G.FeedbackLevel.Run => "run",
                global::G.FeedbackLevel.Session => "session",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/feedbacks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("run", run, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("key", key, delimiter: ",", explode: true) 
                .AddOptionalParameter("session", session, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("user", user, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("has_comment", hasComment?.ToString()) 
                .AddOptionalParameter("has_score", hasScore?.ToString()) 
                .AddOptionalParameter("level", levelValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadSharedFeedbacksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                shareToken: shareToken,
                run: run,
                key: key,
                session: session,
                source: source,
                limit: limit,
                offset: offset,
                user: user,
                hasComment: hasComment,
                hasScore: hasScore,
                level: level);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadSharedFeedbacksResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
                ProcessReadSharedFeedbacksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.FeedbackSchema>?>(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.FeedbackSchema>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}