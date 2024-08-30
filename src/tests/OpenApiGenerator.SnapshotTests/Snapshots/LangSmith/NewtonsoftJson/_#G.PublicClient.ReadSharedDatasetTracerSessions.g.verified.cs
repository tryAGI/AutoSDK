//HintName: G.PublicClient.ReadSharedDatasetTracerSessions.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetTracerSessionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<string, object>? name,
            ref global::System.AnyOf<string, object>? nameContains,
            ref global::System.AnyOf<string, object>? datasetVersion,
            ref global::System.AllOf<global::G.SessionSortableColumns?>? sortBy,
            ref bool sortByDesc,
            ref global::System.AnyOf<string, object>? sortByFeedbackKey,
            ref int offset,
            ref int limit,
            ref bool facets,
            ref global::System.AnyOf<string, object>? accept);
        partial void PrepareReadSharedDatasetTracerSessionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<string, object>? name,
            global::System.AnyOf<string, object>? nameContains,
            global::System.AnyOf<string, object>? datasetVersion,
            global::System.AllOf<global::G.SessionSortableColumns?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<string, object>? sortByFeedbackKey,
            int offset,
            int limit,
            bool facets,
            global::System.AnyOf<string, object>? accept);
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
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
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
            string shareToken,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id = default,
            global::System.AnyOf<string, object>? name = default,
            global::System.AnyOf<string, object>? nameContains = default,
            global::System.AnyOf<string, object>? datasetVersion = default,
            global::System.AllOf<global::G.SessionSortableColumns?>? sortBy = default,
            bool sortByDesc = true,
            global::System.AnyOf<string, object>? sortByFeedbackKey = default,
            int offset = 0,
            int limit = 100,
            bool facets = false,
            global::System.AnyOf<string, object>? accept = default,
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/sessions?id={id}&name={name}&name_contains={nameContains}&dataset_version={datasetVersion}&sort_by={sortBy}&sort_by_desc={sortByDesc}&sort_by_feedback_key={sortByFeedbackKey}&offset={offset}&limit={limit}&facets={facets}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.TracerSession>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}