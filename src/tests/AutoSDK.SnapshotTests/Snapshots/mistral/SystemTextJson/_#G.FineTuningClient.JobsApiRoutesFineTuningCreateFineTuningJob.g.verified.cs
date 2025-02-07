//HintName: G.FineTuningClient.JobsApiRoutesFineTuningCreateFineTuningJob.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareJobsApiRoutesFineTuningCreateFineTuningJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? dryRun,
            global::G.JobIn request);
        partial void PrepareJobsApiRoutesFineTuningCreateFineTuningJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? dryRun,
            global::G.JobIn request);
        partial void ProcessJobsApiRoutesFineTuningCreateFineTuningJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessJobsApiRoutesFineTuningCreateFineTuningJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.JobOut, global::G.LegacyJobMetadataOut>> JobsApiRoutesFineTuningCreateFineTuningJobAsync(
            global::G.JobIn request,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareJobsApiRoutesFineTuningCreateFineTuningJobArguments(
                httpClient: HttpClient,
                dryRun: ref dryRun,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/fine_tuning/jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("dry_run", dryRun?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            PrepareJobsApiRoutesFineTuningCreateFineTuningJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dryRun: dryRun,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessJobsApiRoutesFineTuningCreateFineTuningJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessJobsApiRoutesFineTuningCreateFineTuningJobResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.AnyOf<global::G.JobOut, global::G.LegacyJobMetadataOut>.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.AnyOf<global::G.JobOut, global::G.LegacyJobMetadataOut>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="autoStart">
        /// This field will be required in a future release.
        /// </param>
        /// <param name="hyperparameters">
        /// The fine-tuning hyperparameter settings used in a fine-tune job.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="suffix">
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </param>
        /// <param name="trainingFiles">
        /// Default Value: []
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.JobOut, global::G.LegacyJobMetadataOut>> JobsApiRoutesFineTuningCreateFineTuningJobAsync(
            global::G.TrainingParametersIn hyperparameters,
            global::G.FineTuneableModel model,
            bool? dryRun = default,
            bool? autoStart = default,
            global::System.Collections.Generic.IList<global::G.IntegrationsItem2>? integrations = default,
            global::System.Collections.Generic.IList<global::G.RepositoriesItem2>? repositories = default,
            string? suffix = default,
            global::System.Collections.Generic.IList<global::G.TrainingFile>? trainingFiles = default,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.JobIn
            {
                AutoStart = autoStart,
                Hyperparameters = hyperparameters,
                Integrations = integrations,
                Model = model,
                Repositories = repositories,
                Suffix = suffix,
                TrainingFiles = trainingFiles,
                ValidationFiles = validationFiles,
            };

            return await JobsApiRoutesFineTuningCreateFineTuningJobAsync(
                dryRun: dryRun,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}