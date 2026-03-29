//HintName: G.RunsClient.ListRuns.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class RunsClient
    {
        partial void PrepareListRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            ref string? conversationId,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListRunsOrder? order,
            ref string? orderBy,
            ref bool? active,
            ref bool? ascending);
        partial void PrepareListRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            string? conversationId,
            string? before,
            string? after,
            int? limit,
            global::G.ListRunsOrder? order,
            string? orderBy,
            bool? active,
            bool? ascending);
        partial void ProcessListRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Runs<br/>
        /// List all runs.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with the run.
        /// </param>
        /// <param name="agentIds">
        /// The unique identifiers of the agents associated with the run. Deprecated in favor of agent_id field.
        /// </param>
        /// <param name="statuses">
        /// Filter runs by status. Can specify multiple statuses.
        /// </param>
        /// <param name="background">
        /// If True, filters for runs that were created in background mode.
        /// </param>
        /// <param name="stopReason">
        /// Filter runs by stop reason.
        /// </param>
        /// <param name="conversationId">
        /// Filter runs by conversation ID.
        /// </param>
        /// <param name="before">
        /// Run ID cursor for pagination. Returns runs that come before this run ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Run ID cursor for pagination. Returns runs that come after this run ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of runs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for runs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="active">
        /// Filter for active runs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default). Deprecated in favor of order field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Run>> ListRunsAsync(
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            bool? background = default,
            global::G.StopReasonType? stopReason = default,
            string? conversationId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListRunsOrder? order = default,
            string? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListRunsArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                agentIds: agentIds,
                statuses: statuses,
                background: background,
                stopReason: stopReason,
                conversationId: ref conversationId,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                active: ref active,
                ascending: ref ascending);

            var orderValue = order switch
            {
                global::G.ListRunsOrder.Asc => "asc",
                global::G.ListRunsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/runs/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("agent_ids", agentIds?.ToString())
                .AddOptionalParameter("statuses", statuses?.ToString())
                .AddOptionalParameter("background", background?.ToString().ToLowerInvariant())
                .AddOptionalParameter("stop_reason", stopReason?.ToString())
                .AddOptionalParameter("conversation_id", conversationId)
                .AddOptionalParameter("before", before)
                .AddOptionalParameter("after", after)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("order_by", orderBy)
                .AddOptionalParameter("active", active?.ToString().ToLowerInvariant())
                .AddOptionalParameter("ascending", ascending?.ToString().ToLowerInvariant()) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                agentIds: agentIds,
                statuses: statuses,
                background: background,
                stopReason: stopReason,
                conversationId: conversationId,
                before: before,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy,
                active: active,
                ascending: ascending);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListRunsResponse(
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
                ProcessListRunsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Run>?>(__content, JsonSerializerOptions) ??
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
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Run>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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