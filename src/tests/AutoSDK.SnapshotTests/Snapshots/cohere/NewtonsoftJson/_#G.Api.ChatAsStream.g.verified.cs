//HintName: G.Api.ChatAsStream.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {


        private static readonly global::G.EndPointSecurityRequirement s_ChatAsStreamSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ChatAsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ChatAsStreamSecurityRequirement0,
            };
        partial void PrepareChatAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            ref global::G.ChatAccepts? accepts,
            global::G.ChatRequest request);
        partial void PrepareChatAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.ChatAccepts? accepts,
            global::G.ChatRequest request);
        partial void ProcessChatAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Chat V1 API<br/>
        /// Generates a text response to a user message.<br/>
        /// To learn how to use the Chat API and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="accepts"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamedChatResponse> ChatAsStreamAsync(

            global::G.ChatRequest request,
            string? xClientName = default,
            global::G.ChatAccepts? accepts = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::G.ChatRequest
            {
                Message = request.Message,
                Model = request.Model,
                Stream = true,
                Preamble = request.Preamble,
                ChatHistory = request.ChatHistory,
                ConversationId = request.ConversationId,
                PromptTruncation = request.PromptTruncation,
                Connectors = request.Connectors,
                SearchQueriesOnly = request.SearchQueriesOnly,
                Documents = request.Documents,
                CitationQuality = request.CitationQuality,
                Temperature = request.Temperature,
                MaxTokens = request.MaxTokens,
                MaxInputTokens = request.MaxInputTokens,
                K = request.K,
                P = request.P,
                Seed = request.Seed,
                StopSequences = request.StopSequences,
                FrequencyPenalty = request.FrequencyPenalty,
                PresencePenalty = request.PresencePenalty,
                Tools = request.Tools,
                ToolResults = request.ToolResults,
                ForceSingleStep = request.ForceSingleStep,
                ResponseFormat = request.ResponseFormat,
                SafetyMode = request.SafetyMode,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatAsStreamArguments(
                httpClient: HttpClient,
                xClientName: ref xClientName,
                accepts: ref accepts,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatAsStreamSecurityRequirements,
                operationName: "ChatAsStreamAsync");

            var acceptsValue = accepts switch
            {
                global::G.ChatAccepts.TextEventStream => "text/event-stream",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/chat",
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
            if (accepts != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Accepts", accepts?.ToValueString() ?? string.Empty);
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
            PrepareChatAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xClientName: xClientName,
                accepts: accepts,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatAsStreamResponse(
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

                var __streamedResponse = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StreamedChatResponse?>(__content, JsonSerializerOptions) ??
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
        /// Chat V1 API<br/>
        /// Generates a text response to a user message.<br/>
        /// To learn how to use the Chat API and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="accepts"></param>
        /// <param name="message">
        /// Text input for the model to respond to.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="model">
        /// The name of a compatible [Cohere model](https://docs.cohere.com/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/docs/chat-fine-tuning) model.<br/>
        /// Compatible Deployments: Cohere Platform, Private Deployments
        /// </param>
        /// <param name="preamble">
        /// When specified, the default Cohere preamble will be replaced with the provided one. Preambles are a part of the prompt used to adjust the model's overall behavior and conversation style, and use the `SYSTEM` role.<br/>
        /// The `SYSTEM` role is also used for the contents of the optional `chat_history=` parameter. When used with the `chat_history=` parameter it adds content throughout a conversation. Conversely, when used with the `preamble=` parameter it adds content at the start of the conversation only.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="chatHistory">
        /// A list of previous messages between the user and the model, giving the model conversational context for responding to the user's `message`.<br/>
        /// Each item represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.<br/>
        /// The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="conversationId">
        /// An alternative to `chat_history`.<br/>
        /// Providing a `conversation_id` creates or resumes a persisted conversation with the specified ID. The ID can be any non empty string.<br/>
        /// Compatible Deployments: Cohere Platform
        /// </param>
        /// <param name="promptTruncation">
        /// Defaults to `AUTO` when `connectors` are specified and `OFF` in all other cases.<br/>
        /// Dictates how the prompt will be constructed.<br/>
        /// With `prompt_truncation` set to "AUTO", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be changed and ranked by relevance.<br/>
        /// With `prompt_truncation` set to "AUTO_PRESERVE_ORDER", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved as they are inputted into the API.<br/>
        /// With `prompt_truncation` set to "OFF", no elements will be dropped. If the sum of the inputs exceeds the model's context length limit, a `TooManyTokens` error will be returned.<br/>
        /// Compatible Deployments:<br/>
        ///  - AUTO: Cohere Platform Only<br/>
        ///  - AUTO_PRESERVE_ORDER: Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="connectors">
        /// Accepts `{"id": "web-search"}`, and/or the `"id"` for a custom [connector](https://docs.cohere.com/docs/connectors), if you've [created](https://docs.cohere.com/v1/docs/creating-and-deploying-a-connector) one.<br/>
        /// When specified, the model's reply will be enriched with information found by querying each of the connectors (RAG).<br/>
        /// Compatible Deployments: Cohere Platform
        /// </param>
        /// <param name="searchQueriesOnly">
        /// Defaults to `false`.<br/>
        /// When `true`, the response will only contain a list of generated search queries, but no search will take place, and no reply from the model to the user's `message` will be generated.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="documents">
        /// A list of relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// [<br/>
        ///   { "title": "Tall penguins", "text": "Emperor penguins are the tallest." },<br/>
        ///   { "title": "Penguin habitats", "text": "Emperor penguins only live in Antarctica." },<br/>
        /// ]<br/>
        /// ```<br/>
        /// Keys and values from each document will be serialized to a string and passed to the model. The resulting generation will include citations that reference some of these documents.<br/>
        /// Some suggested keys are "text", "author", and "date". For better generation quality, it is recommended to keep the total word count of the strings in the dictionary to under 300 words.<br/>
        /// An `id` field (string) can be optionally supplied to identify the document in the citations. This field will not be passed to the model.<br/>
        /// An `_excludes` field (array of strings) can be optionally supplied to omit some key-value pairs from being shown to the model. The omitted fields will still show up in the citation object. The "_excludes" field will not be passed to the model.<br/>
        /// See ['Document Mode'](https://docs.cohere.com/docs/retrieval-augmented-generation-rag#document-mode) in the guide for more information.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="citationQuality">
        /// Defaults to `"accurate"`.<br/>
        /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="temperature">
        /// Defaults to `0.3`.<br/>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.<br/>
        /// Randomness can be further maximized by increasing the  value of the `p` parameter.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </param>
        /// <param name="maxInputTokens">
        /// The maximum number of input tokens to send to the model. If not specified, `max_input_tokens` is the model's context length limit minus a small buffer.<br/>
        /// Input will be truncated according to the `prompt_truncation` parameter.<br/>
        /// Compatible Deployments: Cohere Platform<br/>
        /// Included only in requests
        /// </param>
        /// <param name="k">
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0<br/>
        /// Included only in requests
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0.75<br/>
        /// Included only in requests
        /// </param>
        /// <param name="seed">
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="stopSequences">
        /// A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </param>
        /// <param name="frequencyPenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </param>
        /// <param name="tools">
        /// A list of available tools (functions) that the model may suggest invoking before producing a text response.<br/>
        /// When `tools` is passed (without `tool_results`), the `text` field in the response will be `""` and the `tool_calls` field in the response will be populated with a list of tool calls that need to be made. If no calls need to be made, the `tool_calls` array will be empty.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="toolResults">
        /// A list of results from invoking tools recommended by the model in the previous chat turn. Results are used to produce a text response and will be referenced in citations. When using `tool_results`, `tools` must be passed as well.<br/>
        /// Each tool_result contains information about how it was invoked, as well as a list of outputs in the form of dictionaries.<br/>
        /// **Note**: `outputs` must be a list of objects. If your tool returns a single object (eg `{"status": 200}`), make sure to wrap it in a list.<br/>
        /// ```<br/>
        /// tool_results = [<br/>
        ///   {<br/>
        ///     "call": {<br/>
        ///       "name": &lt;tool name&gt;,<br/>
        ///       "parameters": {<br/>
        ///         &lt;param name&gt;: &lt;param value&gt;<br/>
        ///       }<br/>
        ///     },<br/>
        ///     "outputs": [{<br/>
        ///       &lt;key&gt;: &lt;value&gt;<br/>
        ///     }]<br/>
        ///   },<br/>
        ///   ...<br/>
        /// ]<br/>
        /// ```<br/>
        /// **Note**: Chat calls with `tool_results` should not be included in the Chat history to avoid duplication of the message text.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="forceSingleStep">
        /// Forces the chat to be single step. Defaults to `false`.
        /// </param>
        /// <param name="responseFormat">
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R 03-2024](https://docs.cohere.com/docs/command-r), [Command R+ 04-2024](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
        /// </param>
        /// <param name="safetyMode">
        /// Used to select the [safety instruction](https://docs.cohere.com/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
        /// When `NONE` is specified, the safety instruction will be omitted.<br/>
        /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
        /// **Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).<br/>
        /// **Note**: `command-r7b-12-2024` and newer models only support `"CONTEXTUAL"` and `"STRICT"` modes.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamedChatResponse> ChatAsStreamAsync(
            string message,
            int maxTokens,
            int maxInputTokens,
            int k,
            double p,
            global::System.Collections.Generic.IList<string> stopSequences,
            double frequencyPenalty,
            double presencePenalty,
            string? xClientName = default,
            global::G.ChatAccepts? accepts = default,
            string? model = default,
            string? preamble = default,
            global::System.Collections.Generic.IList<global::G.Message>? chatHistory = default,
            string? conversationId = default,
            global::G.ChatRequestPromptTruncation? promptTruncation = default,
            global::System.Collections.Generic.IList<global::G.ChatConnector>? connectors = default,
            bool? searchQueriesOnly = default,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents = default,
            global::G.ChatRequestCitationQuality? citationQuality = default,
            float? temperature = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::System.Collections.Generic.IList<global::G.ToolResult>? toolResults = default,
            bool? forceSingleStep = default,
            global::G.ResponseFormat? responseFormat = default,
            global::G.ChatRequestSafetyMode? safetyMode = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ChatRequest
            {
                Message = message,
                Model = model,
                Stream = true,
                Preamble = preamble,
                ChatHistory = chatHistory,
                ConversationId = conversationId,
                PromptTruncation = promptTruncation,
                Connectors = connectors,
                SearchQueriesOnly = searchQueriesOnly,
                Documents = documents,
                CitationQuality = citationQuality,
                Temperature = temperature,
                MaxTokens = maxTokens,
                MaxInputTokens = maxInputTokens,
                K = k,
                P = p,
                Seed = seed,
                StopSequences = stopSequences,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                Tools = tools,
                ToolResults = toolResults,
                ForceSingleStep = forceSingleStep,
                ResponseFormat = responseFormat,
                SafetyMode = safetyMode,
            };

            var __enumerable = ChatAsStreamAsync(
                xClientName: xClientName,
                accepts: accepts,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}