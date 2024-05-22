//HintName: G.Api.EndPoints.CreateCompletion.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateCompletionResponse> CreateCompletionAsync(
            CreateCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/completions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<CreateCompletionResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="bestOf"></param>
        /// <param name="echo"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="maxTokens"></param>
        /// <param name="n"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="seed"></param>
        /// <param name="stop"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="suffix"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CreateCompletionResponse> CreateCompletionAsync(
            object model,
            object? prompt,
            int? bestOf = default,
            bool? echo = default,
            double? frequencyPenalty = default,
            object? logitBias = default,
            int? logprobs = default,
            int? maxTokens = default,
            int? n = default,
            double? presencePenalty = default,
            int? seed = default,
            object? stop = default,
            bool? stream = default,
            ChatCompletionStreamOptions? streamOptions = default,
            string? suffix = default,
            double? temperature = default,
            double? topP = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateCompletionRequest
            {
                Model = model,
                Prompt = prompt,
                BestOf = bestOf,
                Echo = echo,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                MaxTokens = maxTokens,
                N = n,
                PresencePenalty = presencePenalty,
                Seed = seed,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Suffix = suffix,
                Temperature = temperature,
                TopP = topP,
                User = user,
            };

            return await CreateCompletionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}