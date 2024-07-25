//HintName: G.PublicClient.ReadSharedComparativeExperiments.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedComparativeExperimentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            ref global::System.AnyOf<string, object> name,
            ref global::System.AnyOf<string, object> nameContains,
            ref int offset,
            ref int limit,
            ref global::System.AllOf<global::G.SortByComparativeExperimentColumn> sortBy,
            ref bool sortByDesc);
        partial void PrepareReadSharedComparativeExperimentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::System.AnyOf<string, object> name,
            global::System.AnyOf<string, object> nameContains,
            int offset,
            int limit,
            global::System.AllOf<global::G.SortByComparativeExperimentColumn> sortBy,
            bool sortByDesc);
        partial void ProcessReadSharedComparativeExperimentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedComparativeExperimentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Comparative Experiments<br/>
        /// Get all comparative experiments for a given dataset.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PublicComparativeExperiment>> ReadSharedComparativeExperimentsAsync(
            string shareToken,
            global::System.AnyOf<string, object> name,
            global::System.AnyOf<string, object> nameContains,
            int offset,
            int limit,
            global::System.AllOf<global::G.SortByComparativeExperimentColumn> sortBy,
            bool sortByDesc,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedComparativeExperimentsArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                name: ref name,
                nameContains: ref nameContains,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/comparative?name={name}&name_contains={nameContains}&offset={offset}&limit={limit}&sort_by={sortBy}&sort_by_desc={sortByDesc}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedComparativeExperimentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                name: name,
                nameContains: nameContains,
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
            ProcessReadSharedComparativeExperimentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedComparativeExperimentsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.PublicComparativeExperiment>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}