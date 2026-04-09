//HintName: G.Api.GenerateAsStream.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_GenerateAsStreamSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GenerateAsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GenerateAsStreamSecurityRequirement0,
            };
        partial void PrepareGenerateAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.GenerateRequest request);
        partial void PrepareGenerateAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.GenerateRequest request);
        partial void ProcessGenerateAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Generate<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates realistic text conditioned on a given input.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.GenerateStreamedResponse> GenerateAsStreamAsync(

            global::G.GenerateRequest request,
            string? xClientName = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.GenerateRequest
            {
                Prompt = request.Prompt,
                Model = request.Model,
                NumGenerations = request.NumGenerations,
                Stream = true,
                MaxTokens = request.MaxTokens,
                Truncate = request.Truncate,
                Temperature = request.Temperature,
                Seed = request.Seed,
                Preset = request.Preset,
                EndSequences = request.EndSequences,
                StopSequences = request.StopSequences,
                K = request.K,
                P = request.P,
                FrequencyPenalty = request.FrequencyPenalty,
                PresencePenalty = request.PresencePenalty,
                ReturnLikelihoods = request.ReturnLikelihoods,
                RawPrompting = request.RawPrompting,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareGenerateAsStreamArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateAsStreamSecurityRequirements,
                operationName: "GenerateAsStreamAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/generate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
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
            PrepareGenerateAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);
            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                if (global::System.String.IsNullOrWhiteSpace(__content))
                {
                    continue;
                }

                var __streamedResponse = global::G.GenerateStreamedResponse.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Generate<br/>
        /// &lt;Warning&gt;<br/>
        /// This API is marked as "Legacy" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Generates realistic text conditioned on a given input.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="prompt">
        /// The input text that serves as the starting point for generating the response.<br/>
        /// Note: The prompt will be pre-processed and modified before reaching the model.<br/>
        /// Included only in requests<br/>
        /// Example: Please explain to me how LLMs work
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental).<br/>
        /// Smaller, "light" models are faster, while larger models will perform better. [Custom models](https://docs.cohere.com/docs/training-custom-models) can also be supplied with their full ID.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="numGenerations">
        /// The maximum number of generations that will be returned. Defaults to `1`, min value of `1`, max value of `5`.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.<br/>
        /// This parameter is off by default, and if it's not specified, the model will continue generating until it emits an EOS completion token. See [BPE Tokens](/bpe-tokens-wiki) for more details.<br/>
        /// Can only be set to `0` if `return_likelihoods` is set to `ALL` to get the likelihood of the prompt.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </param>
        /// <param name="temperature">
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations. See [Temperature](/temperature-wiki) for more details.<br/>
        /// Defaults to `0.75`, min value of `0.0`, max value of `5.0`.<br/>
        /// Included only in requests
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
        /// Included only in requests<br/>
        /// Example: my-preset-a58sbd
        /// </param>
        /// <param name="endSequences">
        /// The generated text will be cut at the beginning of the earliest occurrence of an end sequence. The sequence will be excluded from the text.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="stopSequences">
        /// The generated text will be cut at the end of the earliest occurrence of a stop sequence. The sequence will be included the text.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="k">
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="frequencyPenalty">
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Can be used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="returnLikelihoods">
        /// One of `GENERATION|NONE` to specify how and if the token likelihoods are returned with the response. Defaults to `NONE`.<br/>
        /// If `GENERATION` is selected, the token likelihoods will only be provided for generated text.<br/>
        /// WARNING: `ALL` is deprecated, and will be removed in a future release.<br/>
        /// Default Value: NONE
        /// </param>
        /// <param name="rawPrompting">
        /// When enabled, the user's prompt will be sent to the model without any pre-processing.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.GenerateStreamedResponse> GenerateAsStreamAsync(
            string prompt,
            string model,
            int numGenerations,
            int maxTokens,
            global::G.GenerateRequestTruncate truncate,
            double temperature,
            string preset,
            global::System.Collections.Generic.IList<string> endSequences,
            global::System.Collections.Generic.IList<string> stopSequences,
            int k,
            double p,
            double frequencyPenalty,
            double presencePenalty,
            string? xClientName = default,
            int? seed = default,
            global::G.GenerateRequestReturnLikelihoods? returnLikelihoods = default,
            bool? rawPrompting = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.GenerateRequest
            {
                Prompt = prompt,
                Model = model,
                NumGenerations = numGenerations,
                Stream = true,
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

            var __enumerable = GenerateAsStreamAsync(
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}