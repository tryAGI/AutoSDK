//HintName: G.DatasetsClient.DiffDatasetVersions.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareDiffDatasetVersionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            ref global::G.AnyOf<global::System.DateTime?, string> fromVersion,
            ref global::G.AnyOf<global::System.DateTime?, string> toVersion);
        partial void PrepareDiffDatasetVersionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::G.AnyOf<global::System.DateTime?, string> fromVersion,
            global::G.AnyOf<global::System.DateTime?, string> toVersion);
        partial void ProcessDiffDatasetVersionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDiffDatasetVersionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Diff Dataset Versions<br/>
        /// Get diff between two dataset versions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="fromVersion"></param>
        /// <param name="toVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DatasetDiffInfo> DiffDatasetVersionsAsync(
            global::System.Guid datasetId,
            global::G.AnyOf<global::System.DateTime?, string> fromVersion,
            global::G.AnyOf<global::System.DateTime?, string> toVersion,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDiffDatasetVersionsArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                fromVersion: ref fromVersion,
                toVersion: ref toVersion);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/datasets/{datasetId}/versions/diff",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("from_version", fromVersion.ToString() ?? string.Empty) 
                .AddRequiredParameter("to_version", toVersion.ToString() ?? string.Empty) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDiffDatasetVersionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                fromVersion: fromVersion,
                toVersion: toVersion);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDiffDatasetVersionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDiffDatasetVersionsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DatasetDiffInfo?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}