//HintName: G.RunClient.QueryRuns.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareQueryRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyParamsForRunSchema request);
        partial void PrepareQueryRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyParamsForRunSchema request);
        partial void ProcessQueryRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQueryRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Query Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListRunsResponse> QueryRunsAsync(
            global::G.BodyParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareQueryRunsArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs/query", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareQueryRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessQueryRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessQueryRunsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListRunsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Query Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType"></param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="select">
        /// Default Value: [id, name, run_type, start_time, end_time, status, error, extra, events, inputs, outputs, parent_run_id, manifest_id, manifest_s3_id, session_id, serialized, reference_example_id, total_tokens, prompt_tokens, completion_tokens, total_cost, prompt_cost, completion_cost, price_model_id, first_token_time, trace_id, dotted_order, last_queued_at, feedback_stats, child_run_ids, parent_run_ids, tags, in_dataset, app_path, share_token, trace_tier, trace_first_received_at, ttl_seconds, trace_upgrade]
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListRunsResponse> QueryRunsAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, object?>? id = default,
            global::System.AnyOf<string?, object?>? trace = default,
            global::System.AnyOf<string?, object?>? parentRun = default,
            global::System.AnyOf<global::G.RunTypeEnum?, object?>? runType = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, object?>? session = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string?>?, object?>? referenceExample = default,
            global::System.AnyOf<int, object?>? executionOrder = default,
            global::System.AnyOf<global::System.DateTime, object?>? startTime = default,
            global::System.AnyOf<global::System.DateTime, object?>? endTime = default,
            global::System.AnyOf<bool, object?>? error = default,
            global::System.AnyOf<string?, object?>? query = default,
            global::System.AnyOf<string?, object?>? filter = default,
            global::System.AnyOf<string?, object?>? traceFilter = default,
            global::System.AnyOf<string?, object?>? treeFilter = default,
            global::System.AnyOf<bool, object?>? isRoot = default,
            global::System.AnyOf<global::G.RunsFilterDataSourceTypeEnum?, object?>? dataSourceType = default,
            global::System.AnyOf<string?, object?>? cursor = default,
            int limit = 100,
            global::System.Collections.Generic.IList<global::G.RunSelect>? select = default,
            global::System.AllOf<global::G.RunDateOrder?>? order = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyParamsForRunSchema
            {
                Id = id,
                Trace = trace,
                ParentRun = parentRun,
                RunType = runType,
                Session = session,
                ReferenceExample = referenceExample,
                ExecutionOrder = executionOrder,
                StartTime = startTime,
                EndTime = endTime,
                Error = error,
                Query = query,
                Filter = filter,
                TraceFilter = traceFilter,
                TreeFilter = treeFilter,
                IsRoot = isRoot,
                DataSourceType = dataSourceType,
                Cursor = cursor,
                Limit = limit,
                Select = select,
                Order = order,
            };

            return await QueryRunsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}