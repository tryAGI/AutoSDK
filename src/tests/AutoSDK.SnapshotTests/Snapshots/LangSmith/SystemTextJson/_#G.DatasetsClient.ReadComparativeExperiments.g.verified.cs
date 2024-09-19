//HintName: G.DatasetsClient.ReadComparativeExperiments.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareReadComparativeExperimentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            ref global::G.AnyOf<string, object>? name,
            ref global::G.AnyOf<string, object>? nameContains,
            ref global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            ref int? offset,
            ref int? limit,
            ref global::G.AllOf<global::G.SortByComparativeExperimentColumn?>? sortBy,
            ref bool? sortByDesc);
        partial void PrepareReadComparativeExperimentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::G.AnyOf<string, object>? name,
            global::G.AnyOf<string, object>? nameContains,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id,
            int? offset,
            int? limit,
            global::G.AllOf<global::G.SortByComparativeExperimentColumn?>? sortBy,
            bool? sortByDesc);
        partial void ProcessReadComparativeExperimentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadComparativeExperimentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Comparative Experiments<br/>
        /// Get all comparative experiments for a given dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ComparativeExperiment>> ReadComparativeExperimentsAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<string, object>? name = default,
            global::G.AnyOf<string, object>? nameContains = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            int? offset = 0,
            int? limit = 100,
            global::G.AllOf<global::G.SortByComparativeExperimentColumn?>? sortBy = default,
            bool? sortByDesc = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadComparativeExperimentsArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                name: ref name,
                nameContains: ref nameContains,
                id: ref id,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/datasets/{datasetId}/comparative",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("name", name?.ToString() ?? string.Empty) 
                .AddOptionalParameter("name_contains", nameContains?.ToString() ?? string.Empty) 
                .AddOptionalParameter("id", id?.ToString() ?? string.Empty) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("sort_by", sortBy?.ToString() ?? string.Empty) 
                .AddOptionalParameter("sort_by_desc", sortByDesc?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadComparativeExperimentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                name: name,
                nameContains: nameContains,
                id: id,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadComparativeExperimentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadComparativeExperimentsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ComparativeExperiment>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}