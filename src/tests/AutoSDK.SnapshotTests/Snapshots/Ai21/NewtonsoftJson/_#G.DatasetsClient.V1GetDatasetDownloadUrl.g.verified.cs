//HintName: G.DatasetsClient.V1GetDatasetDownloadUrl.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareV1GetDatasetDownloadUrlArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetPid,
            ref string datasetName);
        partial void PrepareV1GetDatasetDownloadUrlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetPid,
            string datasetName);
        partial void ProcessV1GetDatasetDownloadUrlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1GetDatasetDownloadUrlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Dataset Download Url
        /// </summary>
        /// <param name="datasetPid"></param>
        /// <param name="datasetName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1GetDatasetDownloadUrlAsync(
            string datasetPid,
            string datasetName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1GetDatasetDownloadUrlArguments(
                httpClient: HttpClient,
                datasetPid: ref datasetPid,
                datasetName: ref datasetName);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/dataset/url/{datasetPid}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("dataset_name", datasetName) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1GetDatasetDownloadUrlRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetPid: datasetPid,
                datasetName: datasetName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1GetDatasetDownloadUrlResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1GetDatasetDownloadUrlResponseContent(
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

            return __content;
        }
    }
}