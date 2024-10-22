//HintName: G.DatasetsClient.UploadExperiment.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareUploadExperimentArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ExperimentResultsUpload request);
        partial void PrepareUploadExperimentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ExperimentResultsUpload request);
        partial void ProcessUploadExperimentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadExperimentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExperimentResultsUploadResult> UploadExperimentAsync(
            global::G.ExperimentResultsUpload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadExperimentArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/datasets/upload-experiment",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareUploadExperimentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadExperimentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUploadExperimentResponseContent(
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
                global::G.ExperimentResultsUploadResult.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentDescription"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetDescription"></param>
        /// <param name="summaryExperimentScores"></param>
        /// <param name="results"></param>
        /// <param name="experimentStartTime"></param>
        /// <param name="experimentEndTime"></param>
        /// <param name="experimentMetadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ExperimentResultsUploadResult> UploadExperimentAsync(
            string experimentName,
            global::System.Collections.Generic.IList<global::G.ExperimentResultRow> results,
            global::System.DateTime experimentStartTime,
            global::System.DateTime experimentEndTime,
            string? experimentDescription = default,
            global::System.Guid? datasetId = default,
            string? datasetName = default,
            string? datasetDescription = default,
            global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? summaryExperimentScores = default,
            object? experimentMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ExperimentResultsUpload
            {
                ExperimentName = experimentName,
                ExperimentDescription = experimentDescription,
                DatasetId = datasetId,
                DatasetName = datasetName,
                DatasetDescription = datasetDescription,
                SummaryExperimentScores = summaryExperimentScores,
                Results = results,
                ExperimentStartTime = experimentStartTime,
                ExperimentEndTime = experimentEndTime,
                ExperimentMetadata = experimentMetadata,
            };

            return await UploadExperimentAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}