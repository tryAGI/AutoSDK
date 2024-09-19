//HintName: G.Api.CreateMessage.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateMessageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateMessageRequest request);
        partial void PrepareCreateMessageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateMessageRequest request);
        partial void ProcessCreateMessageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateMessageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Message<br/>
        /// Send a structured list of input messages with text and/or image content, and the<br/>
        /// model will generate the next message in the conversation.<br/>
        /// The Messages API can be used for either single queries or stateless multi-turn<br/>
        /// conversations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Message> CreateMessageAsync(
            global::G.CreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateMessageArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/messages",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateMessageRequest(
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
            ProcessCreateMessageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateMessageResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Message?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a Message<br/>
        /// Send a structured list of input messages with text and/or image content, and the<br/>
        /// model will generate the next message in the conversation.<br/>
        /// The Messages API can be used for either single queries or stateless multi-turn<br/>
        /// conversations.
        /// </summary>
        /// <param name="model">
        /// The model that will complete your prompt.<br/>
        /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional<br/>
        /// details and options.<br/>
        /// Example: claude-3-5-sonnet-20240620
        /// </param>
        /// <param name="messages">
        /// Input messages.<br/>
        /// Our models are trained to operate on alternating `user` and `assistant`<br/>
        /// conversational turns. When creating a new `Message`, you specify the prior<br/>
        /// conversational turns with the `messages` parameter, and the model then generates<br/>
        /// the next `Message` in the conversation.<br/>
        /// Each input message must be an object with a `role` and `content`. You can<br/>
        /// specify a single `user`-role message, or you can include multiple `user` and<br/>
        /// `assistant` messages. The first message must always use the `user` role.<br/>
        /// If the final message uses the `assistant` role, the response content will<br/>
        /// continue immediately from the content in that message. This can be used to<br/>
        /// constrain part of the model's response.<br/>
        /// See [message content](https://docs.anthropic.com/en/api/messages-content) for<br/>
        /// details on how to construct valid message objects.<br/>
        /// Example with a single `user` message:<br/>
        /// ```json<br/>
        /// [{ "role": "user", "content": "Hello, Claude" }]<br/>
        /// ```<br/>
        /// Example with multiple conversational turns:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   { "role": "user", "content": "Hello there." },<br/>
        ///   { "role": "assistant", "content": "Hi, I'm Claude. How can I help you?" },<br/>
        ///   { "role": "user", "content": "Can you explain LLMs in plain English?" }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Example with a partially-filled response from Claude:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "What's the Greek name for Sun? (A) Sol (B) Helios (C) Sun"<br/>
        ///   },<br/>
        ///   { "role": "assistant", "content": "The best answer is (" }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Each input message `content` may be either a single `string` or an array of<br/>
        /// content blocks, where each block has a specific `type`. Using a `string` for<br/>
        /// `content` is shorthand for an array of one content block of type `"text"`. The<br/>
        /// following input messages are equivalent:<br/>
        /// ```json<br/>
        /// { "role": "user", "content": "Hello, Claude" }<br/>
        /// ```<br/>
        /// ```json<br/>
        /// { "role": "user", "content": [{ "type": "text", "text": "Hello, Claude" }] }<br/>
        /// ```<br/>
        /// Starting with Claude 3 models, you can also send image content blocks:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": [<br/>
        ///     {<br/>
        ///       "type": "image",<br/>
        ///       "source": {<br/>
        ///         "type": "base64",<br/>
        ///         "media_type": "image/jpeg",<br/>
        ///         "data": "/9j/4AAQSkZJRg..."<br/>
        ///       }<br/>
        ///     },<br/>
        ///     { "type": "text", "text": "What is in this image?" }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// We currently support the `base64` source type for images, and the `image/jpeg`,<br/>
        /// `image/png`, `image/gif`, and `image/webp` media types.<br/>
        /// See [examples](https://docs.anthropic.com/en/api/messages-examples) for more<br/>
        /// input examples.<br/>
        /// Note that if you want to include a<br/>
        /// [system prompt](https://docs.anthropic.com/en/docs/system-prompts), you can use<br/>
        /// the top-level `system` parameter — there is no `"system"` role for input<br/>
        /// messages in the Messages API.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate before stopping.<br/>
        /// Note that our models may stop _before_ reaching this maximum. This parameter<br/>
        /// only specifies the absolute maximum number of tokens to generate.<br/>
        /// Different models have different maximum values for this parameter. See<br/>
        /// [models](https://docs.anthropic.com/en/docs/models-overview) for details.
        /// </param>
        /// <param name="metadata">
        /// An object describing metadata about the request.
        /// </param>
        /// <param name="stopSequences">
        /// Custom text sequences that will cause the model to stop generating.<br/>
        /// Our models will normally stop when they have naturally completed their turn,<br/>
        /// which will result in a response `stop_reason` of `"end_turn"`.<br/>
        /// If you want the model to stop generating when it encounters custom strings of<br/>
        /// text, you can use the `stop_sequences` parameter. If the model encounters one of<br/>
        /// the custom sequences, the response `stop_reason` value will be `"stop_sequence"`<br/>
        /// and the response `stop_sequence` value will contain the matched stop sequence.
        /// </param>
        /// <param name="system">
        /// System prompt.<br/>
        /// A system prompt is a way of providing context and instructions to Claude, such<br/>
        /// as specifying a particular goal or role. See our<br/>
        /// [guide to system prompts](https://docs.anthropic.com/en/docs/system-prompts).
        /// </param>
        /// <param name="temperature">
        /// Amount of randomness injected into the response.<br/>
        /// Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0`<br/>
        /// for analytical / multiple choice, and closer to `1.0` for creative and<br/>
        /// generative tasks.<br/>
        /// Note that even with `temperature` of `0.0`, the results will not be fully<br/>
        /// deterministic.
        /// </param>
        /// <param name="toolChoice">
        /// How the model should use the provided tools. The model can use a specific tool, <br/>
        /// any available tool, or decide by itself.<br/>
        /// - `auto`: allows Claude to decide whether to call any provided tools or not. This is the default value.<br/>
        /// - `any`: tells Claude that it must use one of the provided tools, but doesn’t force a particular tool.<br/>
        /// - `tool`: allows us to force Claude to always use a particular tool specified in the `name` field.
        /// </param>
        /// <param name="tools">
        /// Definitions of tools that the model may use.<br/>
        /// If you include `tools` in your API request, the model may return `tool_use`<br/>
        /// content blocks that represent the model's use of those tools. You can then run<br/>
        /// those tools using the tool input generated by the model and then optionally<br/>
        /// return results back to the model using `tool_result` content blocks.<br/>
        /// Each tool definition includes:<br/>
        /// - `name`: Name of the tool.<br/>
        /// - `description`: Optional, but strongly-recommended description of the tool.<br/>
        /// - `input_schema`: [JSON schema](https://json-schema.org/) for the tool `input`<br/>
        ///   shape that the model will produce in `tool_use` output content blocks.<br/>
        /// For example, if you defined `tools` as:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "description": "Get the current stock price for a given ticker symbol.",<br/>
        ///     "input_schema": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "ticker": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "The stock ticker symbol, e.g. AAPL for Apple Inc."<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["ticker"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// And then asked the model "What's the S&amp;P 500 at today?", the model might produce<br/>
        /// `tool_use` content blocks in the response like this:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_use",<br/>
        ///     "id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "name": "get_stock_price",<br/>
        ///     "input": { "ticker": "^GSPC" }<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// You might then run your `get_stock_price` tool with `{"ticker": "^GSPC"}` as an<br/>
        /// input, and return the following back to the model in a subsequent `user`<br/>
        /// message:<br/>
        /// ```json<br/>
        /// [<br/>
        ///   {<br/>
        ///     "type": "tool_result",<br/>
        ///     "tool_use_id": "toolu_01D7FLrfh4GYq7yT1ULFeyMV",<br/>
        ///     "content": "259.75 USD"<br/>
        ///   }<br/>
        /// ]<br/>
        /// ```<br/>
        /// Tools can be used for workflows that include running client-side tools and<br/>
        /// functions, or more generally whenever you want the model to produce a particular<br/>
        /// JSON structure of output.<br/>
        /// See our [guide](https://docs.anthropic.com/en/docs/tool-use) for more details.
        /// </param>
        /// <param name="topK">
        /// Only sample from the top K options for each subsequent token.<br/>
        /// Used to remove "long tail" low probability responses.<br/>
        /// [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).<br/>
        /// Recommended for advanced use cases only. You usually only need to use<br/>
        /// `temperature`.
        /// </param>
        /// <param name="topP">
        /// Use nucleus sampling.<br/>
        /// In nucleus sampling, we compute the cumulative distribution over all the options<br/>
        /// for each subsequent token in decreasing probability order and cut it off once it<br/>
        /// reaches a particular probability specified by `top_p`. You should either alter<br/>
        /// `temperature` or `top_p`, but not both.<br/>
        /// Recommended for advanced use cases only. You usually only need to use<br/>
        /// `temperature`.
        /// </param>
        /// <param name="stream">
        /// Whether to incrementally stream the response using server-sent events.<br/>
        /// See [streaming](https://docs.anthropic.com/en/api/messages-streaming) for<br/>
        /// details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Message> CreateMessageAsync(
            global::G.AnyOf<string, global::G.CreateMessageRequestModel?> model,
            global::System.Collections.Generic.IList<global::G.Message> messages,
            int maxTokens,
            global::G.CreateMessageRequestMetadata? metadata = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            string? system = default,
            double? temperature = default,
            global::G.ToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            int? topK = default,
            double? topP = default,
            bool? stream = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateMessageRequest
            {
                Model = model,
                Messages = messages,
                MaxTokens = maxTokens,
                Metadata = metadata,
                StopSequences = stopSequences,
                System = system,
                Temperature = temperature,
                ToolChoice = toolChoice,
                Tools = tools,
                TopK = topK,
                TopP = topP,
                Stream = stream,
            };

            return await CreateMessageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}