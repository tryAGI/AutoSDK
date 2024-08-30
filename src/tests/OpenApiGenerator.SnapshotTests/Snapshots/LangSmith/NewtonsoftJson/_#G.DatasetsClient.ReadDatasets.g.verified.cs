//HintName: G.DatasetsClient.ReadDatasets.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<global::G.DataType2>, global::G.DataType2?, object>? dataType,
            ref global::System.AnyOf<string, object>? name,
            ref global::System.AnyOf<string, object>? nameContains,
            ref global::System.AnyOf<string, object>? metadata,
            ref int offset,
            ref int limit,
            ref global::System.AllOf<global::G.SortByDatasetColumn?>? sortBy,
            ref bool sortByDesc,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId);
        partial void PrepareReadDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.DataType2>, global::G.DataType2?, object>? dataType,
            global::System.AnyOf<string, object>? name,
            global::System.AnyOf<string, object>? nameContains,
            global::System.AnyOf<string, object>? metadata,
            int offset,
            int limit,
            global::System.AllOf<global::G.SortByDatasetColumn?>? sortBy,
            bool sortByDesc,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId);
        partial void ProcessReadDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Datasets<br/>
        /// Get all datasets by query params and owner.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataType"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="metadata"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Default Value: last_session_start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Dataset>> ReadDatasetsAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::G.DataType2>, global::G.DataType2?, object>? dataType = default,
            global::System.AnyOf<string, object>? name = default,
            global::System.AnyOf<string, object>? nameContains = default,
            global::System.AnyOf<string, object>? metadata = default,
            int offset = 0,
            int limit = 100,
            global::System.AllOf<global::G.SortByDatasetColumn?>? sortBy = default,
            bool sortByDesc = true,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadDatasetsArguments(
                httpClient: _httpClient,
                id: ref id,
                dataType: ref dataType,
                name: ref name,
                nameContains: ref nameContains,
                metadata: ref metadata,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc,
                tagValueId: ref tagValueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets?id={id}&data_type={dataType}&name={name}&name_contains={nameContains}&metadata={metadata}&offset={offset}&limit={limit}&sort_by={sortBy}&sort_by_desc={sortByDesc}&tag_value_id={tagValueId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadDatasetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                dataType: dataType,
                name: name,
                nameContains: nameContains,
                metadata: metadata,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc,
                tagValueId: tagValueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadDatasetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadDatasetsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Dataset>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}