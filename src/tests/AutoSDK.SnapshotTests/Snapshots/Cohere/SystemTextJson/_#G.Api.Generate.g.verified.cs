//HintName: G.Api.Generate.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareGenerateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.GenerateRequest request);
        partial void PrepareGenerateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.GenerateRequest request);
        partial void ProcessGenerateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates realistic text conditioned on a given input.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Generation> GenerateAsync(
            global::G.GenerateRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGenerateArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/generate",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGenerateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGenerateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGenerateResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Generation?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates realistic text conditioned on a given input.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="prompt">
        /// The input text that serves as the starting point for generating the response.<br/>
        /// Note: The prompt will be pre-processed and modified before reaching the model.<br/>
        /// Example: Please explain to me how LLMs work
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental).<br/>
        /// Smaller, "light" models are faster, while larger models will perform better. [Custom models](/docs/training-custom-models) can also be supplied with their full ID.
        /// </param>
        /// <param name="numGenerations">
        /// The maximum number of generations that will be returned. Defaults to `1`, min value of `1`, max value of `5`.
        /// </param>
        /// <param name="stream">
        /// When `true`, the response will be a JSON stream of events. Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.<br/>
        /// The final event will contain the complete response, and will contain an `is_finished` field set to `true`. The event will also contain a `finish_reason`, which can be one of the following:<br/>
        /// - `COMPLETE` - the model sent back a finished reply<br/>
        /// - `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens for its context length<br/>
        /// - `ERROR` - something went wrong when generating the reply<br/>
        /// - `ERROR_TOXIC` - the model generated a reply that was deemed toxic
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.<br/>
        /// This parameter is off by default, and if it's not specified, the model will continue generating until it emits an EOS completion token. See [BPE Tokens](/bpe-tokens-wiki) for more details.<br/>
        /// Can only be set to `0` if `return_likelihoods` is set to `ALL` to get the likelihood of the prompt.
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END
        /// </param>
        /// <param name="temperature">
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations. See [Temperature](/temperature-wiki) for more details.<br/>
        /// Defaults to `0.75`, min value of `0.0`, max value of `5.0`.
        /// </param>
        /// <param name="seed">
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="preset">
        /// Identifier of a custom preset. A preset is a combination of parameters, such as prompt, temperature etc. You can create presets in the [playground](https://dashboard.cohere.com/playground/generate).<br/>
        /// When a preset is specified, the `prompt` parameter becomes optional, and any included parameters will override the preset's parameters.<br/>
        /// Example: my-preset-a58sbd
        /// </param>
        /// <param name="endSequences">
        /// The generated text will be cut at the beginning of the earliest occurrence of an end sequence. The sequence will be excluded from the text.
        /// </param>
        /// <param name="stopSequences">
        /// The generated text will be cut at the end of the earliest occurrence of a stop sequence. The sequence will be included the text.
        /// </param>
        /// <param name="k">
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Can be used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.
        /// </param>
        /// <param name="returnLikelihoods">
        /// One of `GENERATION|ALL|NONE` to specify how and if the token likelihoods are returned with the response. Defaults to `NONE`.<br/>
        /// If `GENERATION` is selected, the token likelihoods will only be provided for generated text.<br/>
        /// If `ALL` is selected, the token likelihoods will be provided both for the prompt and the generated text.<br/>
        /// Default Value: NONE
        /// </param>
        /// <param name="rawPrompting">
        /// When enabled, the user's prompt will be sent to the model without any pre-processing.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Generation> GenerateAsync(
            string prompt,
            string? xClientName = default,
            string? model = default,
            int? numGenerations = default,
            bool? stream = default,
            int? maxTokens = default,
            global::G.GenerateRequestTruncate? truncate = global::G.GenerateRequestTruncate.END,
            double? temperature = default,
            int? seed = default,
            string? preset = default,
            global::System.Collections.Generic.IList<string>? endSequences = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? k = default,
            double? p = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            global::G.GenerateRequestReturnLikelihoods? returnLikelihoods = global::G.GenerateRequestReturnLikelihoods.NONE,
            bool? rawPrompting = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GenerateRequest
            {
                Prompt = prompt,
                Model = model,
                NumGenerations = numGenerations,
                Stream = stream,
                MaxTokens = maxTokens,
                Truncate = truncate,
                Temperature = temperature,
                Seed = seed,
                Preset = preset,
                EndSequences = endSequences,
                StopSequences = stopSequences,
                K = k,
                P = p,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                ReturnLikelihoods = returnLikelihoods,
                RawPrompting = rawPrompting,
            };

            return await GenerateAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}