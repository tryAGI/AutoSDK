//HintName: G.FineTuningClient.CreateFineTunes.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        partial void PrepareCreateFineTunesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Request2 request);
        partial void PrepareCreateFineTunesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Request2 request);
        partial void ProcessCreateFineTunesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFineTunesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FinetuneResponse> CreateFineTunesAsync(
            global::G.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFineTunesArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/fine-tunes",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFineTunesRequest(
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
            ProcessCreateFineTunesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFineTunesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FinetuneResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create job<br/>
        /// Use a model to create a fine-tuning job.
        /// </summary>
        /// <param name="trainingFile">
        /// File-ID of a file uploaded to the Together API
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="batchSize">
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="learningRate">
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 1E-05F
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="wandbApiKey">
        /// API key for Weights &amp; Biases integration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FinetuneResponse> CreateFineTunesAsync(
            string trainingFile,
            string model,
            int? nEpochs = 1,
            int? nCheckpoints = 1,
            int? batchSize = 32,
            float? learningRate = 1E-05F,
            string? suffix = default,
            string? wandbApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Request2
            {
                TrainingFile = trainingFile,
                Model = model,
                NEpochs = nEpochs,
                NCheckpoints = nCheckpoints,
                BatchSize = batchSize,
                LearningRate = learningRate,
                Suffix = suffix,
                WandbApiKey = wandbApiKey,
            };

            return await CreateFineTunesAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}