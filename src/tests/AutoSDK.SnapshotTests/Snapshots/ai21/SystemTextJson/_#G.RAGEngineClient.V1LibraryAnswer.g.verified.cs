//HintName: G.RAGEngineClient.V1LibraryAnswer.g.cs

#nullable enable

namespace G
{
    public partial class RAGEngineClient
    {
        partial void PrepareV1LibraryAnswerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            global::G.LibraryAnswerRequest request);
        partial void PrepareV1LibraryAnswerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
            global::G.LibraryAnswerRequest request);
        partial void ProcessV1LibraryAnswerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryAnswerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LibraryAnswerResponse> V1LibraryAnswerAsync(
            global::G.LibraryAnswerRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1LibraryAnswerArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/studio/v1/library/answer",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1LibraryAnswerRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibraryAnswerResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
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
                ProcessV1LibraryAnswerResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LibraryAnswerResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.LibraryAnswerResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LibraryAnswerResponse> V1LibraryAnswerAsync(
            string question,
            int? requestStartTime = default,
            int? maxSegments = default,
            string? path = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::G.QueryFilter? labelsFilter = default,
            global::G.LibraryAnswerRequestLabelsFilterMode? labelsFilterMode = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::G.AnswerLength? answerLength = default,
            global::G.Mode? mode = default,
            global::G.RetrievalStrategy? retrievalStrategy = default,
            double? retrievalSimilarityThreshold = default,
            double? hybridSearchAlpha = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.LibraryAnswerRequest
            {
                Question = question,
                MaxSegments = maxSegments,
                Path = path,
                Labels = labels,
                LabelsFilter = labelsFilter,
                LabelsFilterMode = labelsFilterMode,
                FileIds = fileIds,
                AnswerLength = answerLength,
                Mode = mode,
                RetrievalStrategy = retrievalStrategy,
                RetrievalSimilarityThreshold = retrievalSimilarityThreshold,
                HybridSearchAlpha = hybridSearchAlpha,
            };

            return await V1LibraryAnswerAsync(
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}