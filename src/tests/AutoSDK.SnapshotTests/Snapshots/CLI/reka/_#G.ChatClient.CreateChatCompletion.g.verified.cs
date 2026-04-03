//HintName: G.ChatClient.CreateChatCompletion.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion for the provided messages and model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(

            global::G.CreateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/chat/completions",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareCreateChatCompletionRequest(
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
            ProcessCreateChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
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
                ProcessCreateChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CreateChatCompletionResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.CreateChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a chat completion<br/>
        /// Creates a chat completion for the provided messages and model.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness. 0.0 is deterministic.<br/>
        /// Default Value: 0.4
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling threshold. Only tokens with cumulative probability up to top_p are considered.<br/>
        /// Default Value: 0.95
        /// </param>
        /// <param name="topK">
        /// Consider only top-k most probable tokens at each step.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalizes repeated tokens. Positive values reduce repetition.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="presencePenalty">
        /// Penalizes tokens that have appeared in the output. Positive values encourage new topics.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as server-sent events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which tool is called by the model.
        /// </param>
        /// <param name="research">
        /// Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.
        /// </param>
        /// <param name="responseFormat">
        /// Structured output configuration. Forces the model to return valid JSON matching a schema.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::G.ChatMessageInput> messages,
            string model,
            double? temperature = default,
            int? maxTokens = default,
            double? topP = default,
            int? topK = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            bool? stream = default,
            int? seed = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::G.CreateChatCompletionRequestToolChoice? toolChoice = default,
            global::G.ResearchConfig? research = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                Temperature = temperature,
                MaxTokens = maxTokens,
                TopP = topP,
                TopK = topK,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                Stream = stream,
                Seed = seed,
                Stop = stop,
                Tools = tools,
                ToolChoice = toolChoice,
                Research = research,
                ResponseFormat = responseFormat,
            };

            return await CreateChatCompletionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}