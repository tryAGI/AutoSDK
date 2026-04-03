//HintName: G.StepsClient.ListSteps.g.cs

#nullable enable

namespace G
{
    public partial class StepsClient
    {
        partial void PrepareListStepsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListStepsOrder? order,
            ref string? orderBy,
            ref string? startDate,
            ref string? endDate,
            ref string? model,
            ref string? agentId,
            global::System.Collections.Generic.IList<string>? traceIds,
            global::G.ListStepsFeedback2? feedback,
            bool? hasFeedback,
            global::System.Collections.Generic.IList<string>? tags,
            ref string? projectId,
            ref string? xProject);
        partial void PrepareListStepsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? before,
            string? after,
            int? limit,
            global::G.ListStepsOrder? order,
            string? orderBy,
            string? startDate,
            string? endDate,
            string? model,
            string? agentId,
            global::System.Collections.Generic.IList<string>? traceIds,
            global::G.ListStepsFeedback2? feedback,
            bool? hasFeedback,
            global::System.Collections.Generic.IList<string>? tags,
            string? projectId,
            string? xProject);
        partial void ProcessListStepsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListStepsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Steps<br/>
        /// List steps with optional pagination and date filters.
        /// </summary>
        /// <param name="before">
        /// Return steps before this step ID
        /// </param>
        /// <param name="after">
        /// Return steps after this step ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of steps to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for steps by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="startDate">
        /// Return steps after this ISO datetime (e.g. "2025-01-29T15:01:19-08:00")
        /// </param>
        /// <param name="endDate">
        /// Return steps before this ISO datetime (e.g. "2025-01-29T15:01:19-08:00")
        /// </param>
        /// <param name="model">
        /// Filter by the name of the model used for the step
        /// </param>
        /// <param name="agentId">
        /// Filter by the ID of the agent that performed the step
        /// </param>
        /// <param name="traceIds">
        /// Filter by trace ids returned by the server
        /// </param>
        /// <param name="feedback">
        /// Filter by feedback
        /// </param>
        /// <param name="hasFeedback">
        /// Filter by whether steps have feedback (true) or not (false)
        /// </param>
        /// <param name="tags">
        /// Filter by tags
        /// </param>
        /// <param name="projectId">
        /// Filter by the project ID that is associated with the step (cloud only).
        /// </param>
        /// <param name="xProject">
        /// Filter by project slug to associate with the group (cloud only).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Step>> ListStepsAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListStepsOrder? order = default,
            string? orderBy = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? traceIds = default,
            global::G.ListStepsFeedback2? feedback = default,
            bool? hasFeedback = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? projectId = default,
            string? xProject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListStepsArguments(
                httpClient: HttpClient,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                startDate: ref startDate,
                endDate: ref endDate,
                model: ref model,
                agentId: ref agentId,
                traceIds: traceIds,
                feedback: feedback,
                hasFeedback: hasFeedback,
                tags: tags,
                projectId: ref projectId,
                xProject: ref xProject);

            var orderValue = order switch
            {
                global::G.ListStepsOrder.Asc => "asc",
                global::G.ListStepsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/steps/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("start_date", startDate)
                .AddOptionalParameter("end_date", endDate)
                .AddOptionalParameter("model", model)
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("trace_ids", traceIds?.ToString())
                .AddOptionalParameter("feedback", feedback?.ToString())
                .AddOptionalParameter("has_feedback", hasFeedback?.ToString().ToLowerInvariant())
                .AddOptionalParameter("tags", tags?.ToString())
                .AddOptionalParameter("project_id", projectId) 
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

            if (xProject != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Project", xProject.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListStepsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                before: before,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy,
                startDate: startDate,
                endDate: endDate,
                model: model,
                agentId: agentId,
                traceIds: traceIds,
                feedback: feedback,
                hasFeedback: hasFeedback,
                tags: tags,
                projectId: projectId,
                xProject: xProject);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListStepsResponse(
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
                ProcessListStepsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Step>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Step>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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