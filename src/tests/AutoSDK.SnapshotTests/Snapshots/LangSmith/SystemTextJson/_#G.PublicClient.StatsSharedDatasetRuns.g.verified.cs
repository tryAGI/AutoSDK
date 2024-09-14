//HintName: G.PublicClient.StatsSharedDatasetRuns.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareStatsSharedDatasetRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            global::G.FilterQueryParamsForRunSchema request);
        partial void PrepareStatsSharedDatasetRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::G.FilterQueryParamsForRunSchema request);
        partial void ProcessStatsSharedDatasetRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStatsSharedDatasetRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Stats Shared Dataset Runs<br/>
        /// Get run stats in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunStats> StatsSharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::G.FilterQueryParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStatsSharedDatasetRunsArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/stats", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStatsSharedDatasetRunsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessStatsSharedDatasetRunsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStatsSharedDatasetRunsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.RunStats?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Stats Shared Dataset Runs<br/>
        /// Get run stats in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunStats> StatsSharedDatasetRunsAsync(
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.Guid?, object>? trace = default,
            global::G.AnyOf<global::System.Guid?, object>? parentRun = default,
            global::G.AnyOf<global::G.RunTypeEnum?, object>? runType = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceExample = default,
            global::G.AnyOf<int?, object>? executionOrder = default,
            global::G.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::G.AnyOf<bool?, object>? error = default,
            global::G.AnyOf<string, object>? query = default,
            global::G.AnyOf<string, object>? filter = default,
            global::G.AnyOf<string, object>? traceFilter = default,
            global::G.AnyOf<string, object>? treeFilter = default,
            global::G.AnyOf<bool?, object>? isRoot = default,
            global::G.AnyOf<global::G.RunsFilterDataSourceTypeEnum?, object>? dataSourceType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.FilterQueryParamsForRunSchema
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
            };

            return await StatsSharedDatasetRunsAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}