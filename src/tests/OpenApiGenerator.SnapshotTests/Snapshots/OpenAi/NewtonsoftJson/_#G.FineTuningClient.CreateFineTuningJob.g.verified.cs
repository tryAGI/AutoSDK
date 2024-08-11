//HintName: G.FineTuningClient.CreateFineTuningJob.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareCreateFineTuningJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateFineTuningJobRequest request);
        partial void PrepareCreateFineTuningJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateFineTuningJobRequest request);
        partial void ProcessCreateFineTuningJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFineTuningJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::G.CreateFineTuningJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFineTuningJobArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/fine_tuning/jobs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFineTuningJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFineTuningJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFineTuningJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FineTuningJob?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.<br/>
        /// [Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="model">
        /// The name of the model to fine-tune. You can select one of the<br/>
        /// [supported models](/docs/guides/fine-tuning/which-models-can-be-fine-tuned).<br/>
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="trainingFile">
        /// The ID of an uploaded file that contains training data.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.<br/>
        /// The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input) or [completions](/docs/api-reference/fine-tuning/completions-input) format.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job.
        /// </param>
        /// <param name="suffix">
        /// A string of up to 18 characters that will be added to your fine-tuned model name.<br/>
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
        /// </param>
        /// <param name="validationFile">
        /// The ID of an uploaded file that contains validation data.<br/>
        /// If you provide this file, the data is used to generate validation<br/>
        /// metrics periodically during fine-tuning. These metrics can be viewed in<br/>
        /// the fine-tuning results file.<br/>
        /// The same data should not be present in both train and validation files.<br/>
        /// Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.<br/>
        /// See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.<br/>
        /// Example: file-abc123
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="seed">
        /// The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.<br/>
        /// If a seed is not specified, one will be generated for you.<br/>
        /// Example: 42
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::System.AnyOf<string?, global::G.CreateFineTuningJobRequestModel?> model,
            string trainingFile,
            global::G.CreateFineTuningJobRequestHyperparameters? hyperparameters = default,
            string? suffix = default,
            string? validationFile = default,
            global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? integrations = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateFineTuningJobRequest
            {
                Model = model,
                TrainingFile = trainingFile,
                Hyperparameters = hyperparameters,
                Suffix = suffix,
                ValidationFile = validationFile,
                Integrations = integrations,
                Seed = seed,
            };

            return await CreateFineTuningJobAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}