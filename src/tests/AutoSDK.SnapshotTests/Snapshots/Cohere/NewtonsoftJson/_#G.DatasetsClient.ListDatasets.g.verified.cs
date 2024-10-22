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
                client: HttpClient);
            PrepareListDatasetsArguments(
                httpClient: HttpClient,
                datasetType: ref datasetType,
                before: ref before,
                after: ref after,
                limit: ref limit,
                offset: ref offset,
                validationStatus: ref validationStatus,
                xClientName: ref xClientName);

            var validationStatusValue = validationStatus switch
            {
                global::G.DatasetValidationStatus.Unknown => "unknown",
                global::G.DatasetValidationStatus.Queued => "queued",
                global::G.DatasetValidationStatus.Processing => "processing",
                global::G.DatasetValidationStatus.Failed => "failed",
                global::G.DatasetValidationStatus.Validated => "validated",
                global::G.DatasetValidationStatus.Skipped => "skipped",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/v1/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("datasetType", datasetType) 
                .AddOptionalParameter("before", before?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("after", after?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                .AddOptionalParameter("validationStatus", validationStatusValue?.ToString()) 
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

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListDatasetsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetType: datasetType,
                before: before,
                after: after,
                limit: limit,
                offset: offset,
                validationStatus: validationStatus,
                xClientName: xClientName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListDatasetsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListDatasetsResponseContent(
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
                global::G.ListDatasetsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}