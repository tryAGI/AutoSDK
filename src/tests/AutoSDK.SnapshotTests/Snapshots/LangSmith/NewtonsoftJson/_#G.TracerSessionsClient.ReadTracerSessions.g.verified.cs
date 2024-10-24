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
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadTracerSessionsArguments(
                httpClient: HttpClient,
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
                baseUri: HttpClient.BaseAddress); 
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadTracerSessionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadTracerSessionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadTracerSessionsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.TracerSession>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}