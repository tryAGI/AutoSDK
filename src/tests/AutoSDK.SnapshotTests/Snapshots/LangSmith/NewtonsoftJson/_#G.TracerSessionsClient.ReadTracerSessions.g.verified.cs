//HintName: G.TracerSessionsClient.ReadTracerSessions.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AnyOf<bool?, object>? referenceFree,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceDataset,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref global::G.AnyOf<string, object>? name,
            ref global::G.AnyOf<string, object>? nameContains,
            ref global::G.AnyOf<string, object>? datasetVersion,
            ref global::G.AllOf<global::G.SessionSortableColumns?>? sortBy,
            ref bool? sortByDesc,
            ref global::G.AnyOf<string, object>? metadata,
            ref global::G.AnyOf<string, object>? sortByFeedbackKey,
            ref int? offset,
            ref int? limit,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId,
            ref bool? facets,
            ref global::G.AnyOf<string, object>? accept);
        partial void PrepareReadTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AnyOf<bool?, object>? referenceFree,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceDataset,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            global::G.AnyOf<string, object>? name,
            global::G.AnyOf<string, object>? nameContains,
            global::G.AnyOf<string, object>? datasetVersion,
            global::G.AllOf<global::G.SessionSortableColumns?>? sortBy,
            bool? sortByDesc,
            global::G.AnyOf<string, object>? metadata,
            global::G.AnyOf<string, object>? sortByFeedbackKey,
            int? offset,
            int? limit,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId,
            bool? facets,
            global::G.AnyOf<string, object>? accept);
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
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
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
            global::G.AnyOf<bool?, object>? referenceFree = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceDataset = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<string, object>? name = default,
            global::G.AnyOf<string, object>? nameContains = default,
            global::G.AnyOf<string, object>? datasetVersion = default,
            global::G.AllOf<global::G.SessionSortableColumns?>? sortBy = default,
            bool? sortByDesc = true,
            global::G.AnyOf<string, object>? metadata = default,
            global::G.AnyOf<string, object>? sortByFeedbackKey = default,
            int? offset = 0,
            int? limit = 100,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            bool? facets = false,
            global::G.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadTracerSessionsArguments(
                httpClient: _httpClient,
                referenceFree: ref referenceFree,
                referenceDataset: ref referenceDataset,
                id: ref id,
                name: ref name,
                nameContains: ref nameContains,
                datasetVersion: ref datasetVersion,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                metadata: ref metadata,
                sortByFeedbackKey: ref sortByFeedbackKey,
                offset: ref offset,
                limit: ref limit,
                tagValueId: ref tagValueId,
                facets: ref facets,
                accept: ref accept);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/sessions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("reference_free", referenceFree?.ToString() ?? string.Empty) 
                .AddOptionalParameter("reference_dataset", referenceDataset?.ToString() ?? string.Empty) 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name", name?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("dataset_version", datasetVersion?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_by", sortBy?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                .AddOptionalParameter("metadata", metadata?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_by_feedback_key", sortByFeedbackKey?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("tag_value_id", tagValueId?.ToString() ?? string.Empty) 
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