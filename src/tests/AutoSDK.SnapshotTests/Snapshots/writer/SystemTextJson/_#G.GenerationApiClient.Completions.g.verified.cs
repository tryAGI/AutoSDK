//HintName: G.GenerationApiClient.Completions.g.cs

#nullable enable

namespace G
{
    public partial class GenerationApiClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CompletionsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_CompletionsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CompletionsSecurityRequirement0,
            };
        partial void PrepareCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CompletionsRequest request);
        partial void PrepareCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CompletionsRequest request);
        partial void ProcessCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text generation<br/>
        /// Generate text completions using the specified model and prompt. This endpoint is useful for text generation tasks that don't require conversational context.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/completions \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"model":"palmyra-x-003-instruct","prompt":"Write me a short SEO article about camping gear","max_tokens":150,"temperature":0.7,"top_p":0.9,"stop":["."],"best_of":1,"random_seed":42,"stream":false}'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.CompletionsResponse> CompletionsAsync(

            global::G.CompletionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.CompletionsRequest
            {
                Model = request.Model,
                Prompt = request.Prompt,
                MaxTokens = request.MaxTokens,
                Temperature = request.Temperature,
                TopP = request.TopP,
                Stop = request.Stop,
                BestOf = request.BestOf,
                RandomSeed = request.RandomSeed,
                Stream = false,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCompletionsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CompletionsSecurityRequirements,
                operationName: "CompletionsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/completions",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCompletionsRequest(
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
            ProcessCompletionsResponse(
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
                ProcessCompletionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CompletionsResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.CompletionsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
        /// <summary>
        /// Text generation<br/>
        /// Generate text completions using the specified model and prompt. This endpoint is useful for text generation tasks that don't require conversational context.
        /// </summary>
        /// <param name="model">
        /// The [ID of the model](https://dev.writer.com/home/models) to use for generating text. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.
        /// </param>
        /// <param name="prompt">
        /// The input text that the model will process to generate a response.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that the model can generate in the response.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the model's outputs. Higher values lead to more random outputs, while lower values make the model more deterministic.
        /// </param>
        /// <param name="topP">
        /// Used to control the nucleus sampling, where only the most probable tokens with a cumulative probability of top_p are considered for sampling, providing a way to fine-tune the randomness of predictions.
        /// </param>
        /// <param name="stop">
        /// Specifies stopping conditions for the model's output generation. This can be an array of strings or a single string that the model will look for as a signal to stop generating further tokens.
        /// </param>
        /// <param name="bestOf">
        /// Specifies the number of completions to generate and return the best one. Useful for generating multiple outputs and choosing the best based on some criteria.
        /// </param>
        /// <param name="randomSeed">
        /// A seed used to initialize the random number generator for the model, ensuring reproducibility of the output when the same inputs are provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CompletionsResponse> CompletionsAsync(
            string model,
            string prompt,
            long? maxTokens = default,
            double? temperature = default,
            double? topP = default,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop = default,
            int? bestOf = default,
            int? randomSeed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CompletionsRequest
            {
                Model = model,
                Prompt = prompt,
                MaxTokens = maxTokens,
                Temperature = temperature,
                TopP = topP,
                Stop = stop,
                BestOf = bestOf,
                RandomSeed = randomSeed,
                Stream = false,
            };

            return await CompletionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}