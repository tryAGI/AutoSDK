//HintName: G.TracerSessionsClient.ReadTracerSessions.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<bool?, object>? referenceFree,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? referenceDataset,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<string?, object>? name,
            ref global::System.AnyOf<string?, object>? nameContains,
            ref global::System.AnyOf<string?, object>? datasetVersion,
            ref global::System.AllOf<global::G.SessionSortableColumns?>? sortBy,
            ref bool sortByDesc,
            ref global::System.AnyOf<string?, object>? metadata,
            ref global::System.AnyOf<string?, object>? sortByFeedbackKey,
            ref int offset,
            ref int limit,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            ref bool facets,
            ref global::System.AnyOf<string?, object>? accept);
        partial void PrepareReadTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<bool?, object>? referenceFree,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? referenceDataset,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<string?, object>? datasetVersion,
            global::System.AllOf<global::G.SessionSortableColumns?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<string?, object>? metadata,
            global::System.AnyOf<string?, object>? sortByFeedbackKey,
            int offset,
            int limit,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            bool facets,
            global::System.AnyOf<string?, object>? accept);
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
            global::System.AnyOf<bool?, object>? referenceFree,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? referenceDataset,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<string?, object>? datasetVersion,
            global::System.AllOf<global::G.SessionSortableColumns?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<string?, object>? metadata,
            global::System.AnyOf<string?, object>? sortByFeedbackKey,
            int offset,
            int limit,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            bool facets,
            global::System.AnyOf<string?, object>? accept,
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions?reference_free={referenceFree}&reference_dataset={referenceDataset}&id={id}&name={name}&name_contains={nameContains}&dataset_version={datasetVersion}&sort_by={sortBy}&sort_by_desc={sortByDesc}&metadata={metadata}&sort_by_feedback_key={sortByFeedbackKey}&offset={offset}&limit={limit}&tag_value_id={tagValueId}&facets={facets}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.TracerSession>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}