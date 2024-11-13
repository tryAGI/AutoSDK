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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Generation> GenerateAsync(
            global::G.GenerateRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/generate",
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
            PrepareGenerateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.GenerateResponse? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.GenerateResponse.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.GenerateResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.GenerateResponse2? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.GenerateResponse2.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.GenerateResponse2.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse2>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error indicates that the operation attempted to be performed is not allowed. This could be because:   - The api token is invalid   - The user does not have the necessary permissions 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.GenerateResponse3? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.GenerateResponse3.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.GenerateResponse3.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse3>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a resource is not found. This could be because:   - The endpoint does not exist   - The resource does not exist eg model id, dataset id 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.GenerateResponse4? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.GenerateResponse4.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.GenerateResponse4.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse4>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the request is not well formed. This could be because:   - JSON is invalid   - The request is missing required fields   - The request contains an invalid combination of fields 
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.GenerateResponse5? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.GenerateResponse5.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.GenerateResponse5.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse5>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::G.GenerateResponse6? __value_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = global::G.GenerateResponse6.FromJson(__content_429, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_429 = await global::G.GenerateResponse6.FromJsonStreamAsync(__contentStream_429, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse6>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request or response contains a deny-listed token. 
            if ((int)__response.StatusCode == 498)
            {
                string? __content_498 = null;
                global::G.GenerateResponse7? __value_498 = null;
                if (ReadResponseAsString)
                {
                    __content_498 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = global::G.GenerateResponse7.FromJson(__content_498, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_498 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_498 = await global::G.GenerateResponse7.FromJsonStreamAsync(__contentStream_498, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse7>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_498,
                    ResponseObject = __value_498,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request is cancelled by the user. 
            if ((int)__response.StatusCode == 499)
            {
                string? __content_499 = null;
                global::G.GenerateResponse8? __value_499 = null;
                if (ReadResponseAsString)
                {
                    __content_499 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = global::G.GenerateResponse8.FromJson(__content_499, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_499 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_499 = await global::G.GenerateResponse8.FromJsonStreamAsync(__contentStream_499, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse8>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_499,
                    ResponseObject = __value_499,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when an uncategorised internal server error occurs. 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.GenerateResponse9? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.GenerateResponse9.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.GenerateResponse9.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse9>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the requested feature is not implemented. 
            if ((int)__response.StatusCode == 501)
            {
                string? __content_501 = null;
                global::G.GenerateResponse10? __value_501 = null;
                if (ReadResponseAsString)
                {
                    __content_501 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = global::G.GenerateResponse10.FromJson(__content_501, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_501 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_501 = await global::G.GenerateResponse10.FromJsonStreamAsync(__contentStream_501, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse10>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_501,
                    ResponseObject = __value_501,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when the service is unavailable. This could be due to:   - Too many users trying to access the service at the same time 
            if ((int)__response.StatusCode == 503)
            {
                string? __content_503 = null;
                global::G.GenerateResponse11? __value_503 = null;
                if (ReadResponseAsString)
                {
                    __content_503 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = global::G.GenerateResponse11.FromJson(__content_503, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_503 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_503 = await global::G.GenerateResponse11.FromJsonStreamAsync(__contentStream_503, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse11>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_503,
                    ResponseObject = __value_503,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // This error is returned when a request to the server times out. This could be due to:   - An internal services taking too long to respond 
            if ((int)__response.StatusCode == 504)
            {
                string? __content_504 = null;
                global::G.GenerateResponse12? __value_504 = null;
                if (ReadResponseAsString)
                {
                    __content_504 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = global::G.GenerateResponse12.FromJson(__content_504, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_504 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_504 = await global::G.GenerateResponse12.FromJsonStreamAsync(__contentStream_504, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.GenerateResponse12>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_504,
                    ResponseObject = __value_504,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGenerateResponseContent(
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
                    global::G.Generation.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.Generation.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
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
        /// Included only in requests<br/>
        /// Example: Please explain to me how LLMs work
        /// </param>
        /// <param name="model">
        /// The identifier of the model to generate with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental).<br/>
        /// Smaller, "light" models are faster, while larger models will perform better. [Custom models](/docs/training-custom-models) can also be supplied with their full ID.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="numGenerations">
        /// The maximum number of generations that will be returned. Defaults to `1`, min value of `1`, max value of `5`.<br/>
        /// Included only in requests
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
            bool? stream = default,
            int? seed = default,
            global::G.GenerateRequestReturnLikelihoods? returnLikelihoods = default,
            bool? rawPrompting = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.GenerateRequest
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}