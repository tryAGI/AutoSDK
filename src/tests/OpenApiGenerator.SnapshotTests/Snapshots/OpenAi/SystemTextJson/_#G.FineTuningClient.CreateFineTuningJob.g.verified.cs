//HintName: G.FineTuningClient.CreateFineTuningJob.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.[Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::G.CreateFineTuningJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/fine_tuning/jobs", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FineTuningJob?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.[Learn more about fine-tuning](/docs/guides/fine-tuning)
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trainingFile"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="suffix"></param>
        /// <param name="validationFile"></param>
        /// <param name="integrations"></param>
        /// <param name="seed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FineTuningJob> CreateFineTuningJobAsync(
            global::System.AnyOf<string, global::G.CreateFineTuningJobRequestModel> model,
            string trainingFile,
            global::G.CreateFineTuningJobRequestHyperparameters? hyperparameters = default,
            string? suffix = default,
            string? validationFile = default,
            global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegrations?>? integrations = default,
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