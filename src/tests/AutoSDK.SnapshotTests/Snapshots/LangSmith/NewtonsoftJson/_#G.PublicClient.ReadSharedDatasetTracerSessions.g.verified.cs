//HintName: G.PublicClient.ReadSharedDatasetTracerSessions.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref global::G.AnyOf<string, object>? name,
            ref global::G.AnyOf<string, object>? nameContains,
            ref global::G.AnyOf<string, object>? datasetVersion,
            ref global::G.SessionSortableColumns? sortBy,
            ref bool? sortByDesc,
            ref global::G.AnyOf<string, object>? sortByFeedbackKey,
            ref int? offset,
            ref int? limit,
            ref bool? facets,
            ref global::G.AnyOf<string, object>? accept);
        partial void PrepareReadSharedDatasetTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            global::G.AnyOf<string, object>? name,
            global::G.AnyOf<string, object>? nameContains,
            global::G.AnyOf<string, object>? datasetVersion,
            global::G.SessionSortableColumns? sortBy,
            bool? sortByDesc,
            global::G.AnyOf<string, object>? sortByFeedbackKey,
            int? offset,
            int? limit,
            bool? facets,
            global::G.AnyOf<string, object>? accept);
        partial void ProcessReadSharedDatasetTracerSessionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDatasetTracerSessionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Dataset Tracer Sessions<br/>
        /// Get projects run on a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TracerSession>> ReadSharedDatasetTracerSessionsAsync(
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<string, object>? name = default,
            global::G.AnyOf<string, object>? nameContains = default,
            global::G.AnyOf<string, object>? datasetVersion = default,
            global::G.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = true,
            global::G.AnyOf<string, object>? sortByFeedbackKey = default,
            int? offset = 0,
            int? limit = 100,
            bool? facets = false,
            global::G.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDatasetTracerSessionsArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                id: ref id,
                name: ref name,
                nameContains: ref nameContains,
                datasetVersion: ref datasetVersion,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                sortByFeedbackKey: ref sortByFeedbackKey,
                offset: ref offset,
                limit: ref limit,
                facets: ref facets,
                accept: ref accept);

            var sortByValue = sortBy switch
            {
                global::G.SessionSortableColumns.Name => "name",
                global::G.SessionSortableColumns.StartTime => "start_time",
                global::G.SessionSortableColumns.LastRunStartTime => "last_run_start_time",
                global::G.SessionSortableColumns.LatencyP50 => "latency_p50",
                global::G.SessionSortableColumns.LatencyP99 => "latency_p99",
                global::G.SessionSortableColumns.ErrorRate => "error_rate",
                global::G.SessionSortableColumns.Feedback => "feedback",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/datasets/sessions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name", name?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("dataset_version", datasetVersion?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_by", sortByValue?.ToString()) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                .AddOptionalParameter("sort_by_feedback_key", sortByFeedbackKey?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("facets", facets?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (accept != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("accept", accept.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDatasetTracerSessionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                id: id,
                name: name,
                nameContains: nameContains,
                datasetVersion: datasetVersion,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                sortByFeedbackKey: sortByFeedbackKey,
                offset: offset,
                limit: limit,
                facets: facets,
                accept: accept);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadSharedDatasetTracerSessionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDatasetTracerSessionsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.TracerSession>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}