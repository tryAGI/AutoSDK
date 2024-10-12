//HintName: G.TracerSessionsClient.ReadTracerSessions.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? referenceFree,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            ref string? name,
            ref string? nameContains,
            ref string? datasetVersion,
            ref global::G.SessionSortableColumns? sortBy,
            ref bool? sortByDesc,
            ref string? metadata,
            ref string? sortByFeedbackKey,
            ref int? offset,
            ref int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            ref bool? facets,
            ref string? accept);
        partial void PrepareReadTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? referenceFree,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset,
            global::System.Collections.Generic.IList<global::System.Guid>? id,
            string? name,
            string? nameContains,
            string? datasetVersion,
            global::G.SessionSortableColumns? sortBy,
            bool? sortByDesc,
            string? metadata,
            string? sortByFeedbackKey,
            int? offset,
            int? limit,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            bool? facets,
            string? accept);
        partial void ProcessReadTracerSessionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadTracerSessionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Tracer Sessions<br/>
        /// Get all sessions.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TracerSession>> ReadTracerSessionsAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::G.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = true,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            int? offset = 0,
            int? limit = 100,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = false,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadTracerSessionsArguments(
                httpClient: _httpClient,
                referenceFree: ref referenceFree,
                referenceDataset: referenceDataset,
                id: id,
                name: ref name,
                nameContains: ref nameContains,
                datasetVersion: ref datasetVersion,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                metadata: ref metadata,
                sortByFeedbackKey: ref sortByFeedbackKey,
                offset: ref offset,
                limit: ref limit,
                tagValueId: tagValueId,
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
                path: "/api/v1/sessions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("reference_free", referenceFree?.ToString()) 
                .AddOptionalParameter("reference_dataset", referenceDataset, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("id", id, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("name_contains", nameContains) 
                .AddOptionalParameter("dataset_version", datasetVersion) 
                .AddOptionalParameter("sort_by", sortByValue?.ToString()) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                .AddOptionalParameter("metadata", metadata) 
                .AddOptionalParameter("sort_by_feedback_key", sortByFeedbackKey) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("facets", facets?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (accept != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("accept", accept.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadTracerSessionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                referenceFree: referenceFree,
                referenceDataset: referenceDataset,
                id: id,
                name: name,
                nameContains: nameContains,
                datasetVersion: datasetVersion,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                metadata: metadata,
                sortByFeedbackKey: sortByFeedbackKey,
                offset: offset,
                limit: limit,
                tagValueId: tagValueId,
                facets: facets,
                accept: accept);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadTracerSessionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadTracerSessionsResponseContent(
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