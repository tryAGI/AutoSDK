//HintName: G.Api.Chat.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareChatArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.ChatRequest request);
        partial void PrepareChatRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.ChatRequest request);
        partial void ProcessChatResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chat<br/>
        /// Generates a text response to a user message.<br/>
        /// To learn how to use the Chat API with Streaming and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OneOf<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?>> ChatAsync(
            global::G.ChatRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChatArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/chat", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChatRequest(
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
            ProcessChatResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChatResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.OneOf<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Chat<br/>
        /// Generates a text response to a user message.<br/>
        /// To learn how to use the Chat API with Streaming and RAG follow our [Text Generation guides](https://docs.cohere.com/docs/chat-api).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="message">
        /// Text input for the model to respond to.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="model">
        /// Defaults to `command-r-plus`.<br/>
        /// The name of a compatible [Cohere model](https://docs.cohere.com/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/docs/chat-fine-tuning) model.<br/>
        /// Compatible Deployments: Cohere Platform, Private Deployments
        /// </param>
        /// <param name="stream">
        /// Defaults to `false`.<br/>
        /// When `true`, the response will be a JSON stream of events. The final event will contain the complete response, and will have an `event_type` of `"stream-end"`.<br/>
        /// Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
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
        /// Compatible Deployments: Cohere Platform Only AUTO_PRESERVE_ORDER: Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="connectors">
        /// Accepts `{"id": "web-search"}`, and/or the `"id"` for a custom [connector](https://docs.cohere.com/docs/connectors), if you've [created](https://docs.cohere.com/docs/creating-and-deploying-a-connector) one.<br/>
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
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="maxInputTokens">
        /// The maximum number of input tokens to send to the model. If not specified, `max_input_tokens` is the model's context length limit minus a small buffer.<br/>
        /// Input will be truncated according to the `prompt_truncation` parameter.<br/>
        /// Compatible Deployments: Cohere Platform
        /// </param>
        /// <param name="k">
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="p">
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0.75
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
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="frequencyPenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </param>
        /// <param name="presencePenalty">
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
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
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/docs/command-r), [Command R+](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OneOf<global::G.NonStreamedChatResponse, global::G.StreamedChatResponse?>> ChatAsync(
            string message,
            string? xClientName = default,
            string? model = default,
            bool stream = default,
            string? preamble = default,
            global::System.Collections.Generic.IList<global::G.Message>? chatHistory = default,
            string? conversationId = default,
            global::G.ChatRequestPromptTruncation? promptTruncation = default,
            global::System.Collections.Generic.IList<global::G.ChatConnector>? connectors = default,
            bool searchQueriesOnly = default,
            global::System.Collections.Generic.IList<global::G.ChatDocument>? documents = default,
            global::G.ChatRequestCitationQuality? citationQuality = default,
            float temperature = default,
            int maxTokens = default,
            int maxInputTokens = default,
            int k = 0,
            double p = 0.75,
            int seed = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            double frequencyPenalty = default,
            double presencePenalty = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::System.Collections.Generic.IList<global::G.ToolResult>? toolResults = default,
            bool forceSingleStep = default,
            global::G.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ChatRequest
            {
                Message = message,
                Model = model,
                Stream = stream,
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
            };

            return await ChatAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}