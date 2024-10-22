//HintName: G.DatasetsClient.UpdateDatasetSplits.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareUpdateDatasetSplitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid datasetId,
            global::G.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request);
        partial void PrepareUpdateDatasetSplitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid datasetId,
            global::G.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request);
        partial void ProcessUpdateDatasetSplitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDatasetSplitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> UpdateDatasetSplitsAsync(
            global::System.Guid datasetId,
            global::G.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateDatasetSplitsArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/datasets/{datasetId}/splits",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateDatasetSplitsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateDatasetSplitsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateDatasetSplitsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::System.Guid>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="splitName"></param>
        /// <param name="examples"></param>
        /// <param name="remove">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::System.Guid>> UpdateDatasetSplitsAsync(
            global::System.Guid datasetId,
            string splitName,
            global::System.Collections.Generic.IList<global::System.Guid> examples,
            bool? remove = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut
            {
                SplitName = splitName,
                Examples = examples,
                Remove = remove,
            };

            return await UpdateDatasetSplitsAsync(
                datasetId: datasetId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}