//HintName: G.EvalResultsClient.EvalResultsQueryV2EntityProjectEvalResultsQueryPost.g.cs

#nullable enable

namespace G
{
    public partial class EvalResultsClient
    {
        partial void PrepareEvalResultsQueryV2EntityProjectEvalResultsQueryPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string entity,
            ref string project,
            global::G.EvalResultsQueryBody request);
        partial void PrepareEvalResultsQueryV2EntityProjectEvalResultsQueryPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string entity,
            string project,
            global::G.EvalResultsQueryBody request);
        partial void ProcessEvalResultsQueryV2EntityProjectEvalResultsQueryPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEvalResultsQueryV2EntityProjectEvalResultsQueryPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Eval Results Query<br/>
        /// Read grouped evaluation result rows for one or more evaluations.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EvalResultsQueryRes> EvalResultsQueryV2EntityProjectEvalResultsQueryPostAsync(
            string entity,
            string project,

            global::G.EvalResultsQueryBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEvalResultsQueryV2EntityProjectEvalResultsQueryPostArguments(
                httpClient: HttpClient,
                entity: ref entity,
                project: ref project,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/{entity}/{project}/eval_results/query",
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
            PrepareEvalResultsQueryV2EntityProjectEvalResultsQueryPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                entity: entity,
                project: project,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEvalResultsQueryV2EntityProjectEvalResultsQueryPostResponse(
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
                ProcessEvalResultsQueryV2EntityProjectEvalResultsQueryPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EvalResultsQueryRes.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EvalResultsQueryRes.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Eval Results Query<br/>
        /// Read grouped evaluation result rows for one or more evaluations.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationCallIds">
        /// Evaluation root call IDs to include.
        /// </param>
        /// <param name="evaluationRunIds">
        /// Alias for evaluation call IDs from the Evaluation Runs API.
        /// </param>
        /// <param name="requireIntersection">
        /// When true, only include rows present in all requested evaluations.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawDataRows">
        /// When true, populate raw_data_row on each result row. Inline rows are returned as their dict value; dataset-referenced rows are returned as the ref string unless resolve_row_refs is also true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolveRowRefs">
        /// When true (requires include_raw_data_rows=True), resolve dataset-row reference strings to actual row data via a table lookup. When false, dataset-row refs are returned as-is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRows">
        /// When true, include grouped row/trial data in `rows` and compute `total_rows` for the requested row-level view.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeSummary">
        /// When true, include aggregated scorer/evaluation summary data in `summary`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryRequireIntersection">
        /// Optional intersection behavior for the summary section. When null, the value of `require_intersection` is used.
        /// </param>
        /// <param name="limit">
        /// Optional row-level page size applied after grouping and intersection.
        /// </param>
        /// <param name="offset">
        /// Optional row-level page offset applied after grouping and intersection.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EvalResultsQueryRes> EvalResultsQueryV2EntityProjectEvalResultsQueryPostAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string>? evaluationCallIds = default,
            global::System.Collections.Generic.IList<string>? evaluationRunIds = default,
            bool? requireIntersection = default,
            bool? includeRawDataRows = default,
            bool? resolveRowRefs = default,
            bool? includeRows = default,
            bool? includeSummary = default,
            bool? summaryRequireIntersection = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.EvalResultsQueryBody
            {
                EvaluationCallIds = evaluationCallIds,
                EvaluationRunIds = evaluationRunIds,
                RequireIntersection = requireIntersection,
                IncludeRawDataRows = includeRawDataRows,
                ResolveRowRefs = resolveRowRefs,
                IncludeRows = includeRows,
                IncludeSummary = includeSummary,
                SummaryRequireIntersection = summaryRequireIntersection,
                Limit = limit,
                Offset = offset,
            };

            return await EvalResultsQueryV2EntityProjectEvalResultsQueryPostAsync(
                entity: entity,
                project: project,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}