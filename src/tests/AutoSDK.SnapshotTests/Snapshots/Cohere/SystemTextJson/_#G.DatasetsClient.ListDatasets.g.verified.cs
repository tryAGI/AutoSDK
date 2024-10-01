//HintName: G.DatasetsClient.ListDatasets.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareListDatasetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? datasetType,
            ref global::System.DateTime? before,
            ref global::System.DateTime? after,
            ref double? limit,
            ref double? offset,
            ref global::G.DatasetValidationStatus? validationStatus,
            ref string? xClientName);
        partial void PrepareListDatasetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? datasetType,
            global::System.DateTime? before,
            global::System.DateTime? after,
            double? limit,
            double? offset,
            global::G.DatasetValidationStatus? validationStatus,
            string? xClientName);
        partial void ProcessListDatasetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListDatasetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Datasets<br/>
        /// List datasets that have been created.
        /// </summary>
        /// <param name="datasetType"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="validationStatus">
        /// The validation status of the dataset
        /// </param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListDatasetsResponse> ListDatasetsAsync(
            string? datasetType = default,
            global::System.DateTime? before = default,
            global::System.DateTime? after = default,
            double? limit = default,
            double? offset = default,
            global::G.DatasetValidationStatus? validationStatus = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListDatasetsArguments(
                httpClient: _httpClient,
                datasetType: ref datasetType,
                before: ref before,
                after: ref after,
                limit: ref limit,
                offset: ref offset,
                validationStatus: ref validationStatus,
                xClientName: ref xClientName);

            var __pathBuilder = new PathBuilder(
                path: "/v1/datasets",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("datasetType", datasetType) 
                .AddOptionalParameter("before", before?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("after", after?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("validationStatus", validationStatus?.ToValueString()) 
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

            if (xClientName != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListDatasetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetType: datasetType,
                before: before,
                after: after,
                limit: limit,
                offset: offset,
                validationStatus: validationStatus,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListDatasetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListDatasetsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListDatasetsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}