//HintName: G.Models.ChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// Text input for the model to respond to.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Defaults to `command-r-plus-08-2024`.<br/>
        /// The name of a compatible [Cohere model](https://docs.cohere.com/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/docs/chat-fine-tuning) model.<br/>
        /// Compatible Deployments: Cohere Platform, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Defaults to `false`.<br/>
        /// When `true`, the response will be a JSON stream of events. The final event will contain the complete response, and will have an `event_type` of `"stream-end"`.<br/>
        /// Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// When specified, the default Cohere preamble will be replaced with the provided one. Preambles are a part of the prompt used to adjust the model's overall behavior and conversation style, and use the `SYSTEM` role.<br/>
        /// The `SYSTEM` role is also used for the contents of the optional `chat_history=` parameter. When used with the `chat_history=` parameter it adds content throughout a conversation. Conversely, when used with the `preamble=` parameter it adds content at the start of the conversation only.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preamble")]
        public string? Preamble { get; set; }

        /// <summary>
        /// A list of previous messages between the user and the model, giving the model conversational context for responding to the user's `message`.<br/>
        /// Each item represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.<br/>
        /// The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        public global::System.Collections.Generic.IList<global::G.Message>? ChatHistory { get; set; }

        /// <summary>
        /// An alternative to `chat_history`.<br/>
        /// Providing a `conversation_id` creates or resumes a persisted conversation with the specified ID. The ID can be any non empty string.<br/>
        /// Compatible Deployments: Cohere Platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Defaults to `AUTO` when `connectors` are specified and `OFF` in all other cases.<br/>
        /// Dictates how the prompt will be constructed.<br/>
        /// With `prompt_truncation` set to "AUTO", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be changed and ranked by relevance.<br/>
        /// With `prompt_truncation` set to "AUTO_PRESERVE_ORDER", some elements from `chat_history` and `documents` will be dropped in an attempt to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved as they are inputted into the API.<br/>
        /// With `prompt_truncation` set to "OFF", no elements will be dropped. If the sum of the inputs exceeds the model's context length limit, a `TooManyTokens` error will be returned.<br/>
        /// Compatible Deployments: <br/>
        ///  - AUTO: Cohere Platform Only<br/>
        ///  - AUTO_PRESERVE_ORDER: Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestPromptTruncationJsonConverter))]
        public global::G.ChatRequestPromptTruncation? PromptTruncation { get; set; }

        /// <summary>
        /// Accepts `{"id": "web-search"}`, and/or the `"id"` for a custom [connector](https://docs.cohere.com/docs/connectors), if you've [created](https://docs.cohere.com/docs/creating-and-deploying-a-connector) one.<br/>
        /// When specified, the model's reply will be enriched with information found by querying each of the connectors (RAG).<br/>
        /// Compatible Deployments: Cohere Platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        public global::System.Collections.Generic.IList<global::G.ChatConnector>? Connectors { get; set; }

        /// <summary>
        /// Defaults to `false`.<br/>
        /// When `true`, the response will only contain a list of generated search queries, but no search will take place, and no reply from the model to the user's `message` will be generated.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_queries_only")]
        public bool? SearchQueriesOnly { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Defaults to `"accurate"`.<br/>
        /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestCitationQualityJsonConverter))]
        public global::G.ChatRequestCitationQuality? CitationQuality { get; set; }

        /// <summary>
        /// Defaults to `0.3`.<br/>
        /// A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.<br/>
        /// Randomness can be further maximized by increasing the  value of the `p` parameter.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The maximum number of input tokens to send to the model. If not specified, `max_input_tokens` is the model's context length limit minus a small buffer.<br/>
        /// Input will be truncated according to the `prompt_truncation` parameter.<br/>
        /// Compatible Deployments: Cohere Platform<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")]
        public int? MaxInputTokens { get; set; }

        /// <summary>
        /// Ensures only the top `k` most likely tokens are considered for generation at each step.<br/>
        /// Defaults to `0`, min value of `0`, max value of `500`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public int? K { get; set; }

        /// <summary>
        /// Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.<br/>
        /// Defaults to `0.75`. min value of `0.01`, max value of `0.99`.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Default Value: 0.75<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        public double? P { get; set; }

        /// <summary>
        /// If specified, the backend will make a best effort to sample tokens<br/>
        /// deterministically, such that repeated requests with the same<br/>
        /// seed and parameters should return the same result. However,<br/>
        /// determinism cannot be totally guaranteed.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Defaults to `0.0`, min value of `0.0`, max value of `1.0`.<br/>
        /// Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// A list of available tools (functions) that the model may suggest invoking before producing a text response.<br/>
        /// When `tools` is passed (without `tool_results`), the `text` field in the response will be `""` and the `tool_calls` field in the response will be populated with a list of tool calls that need to be made. If no calls need to be made, the `tool_calls` array will be empty.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_results")]
        public global::System.Collections.Generic.IList<global::G.ToolResult>? ToolResults { get; set; }

        /// <summary>
        /// Forces the chat to be single step. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_single_step")]
        public bool? ForceSingleStep { get; set; }

        /// <summary>
        /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R 03-2024](https://docs.cohere.com/docs/command-r), [Command R+ 04-2024](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
        /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
        /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
        /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
        /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatJsonConverter))]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Used to select the [safety instruction](/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.<br/>
        /// When `NONE` is specified, the safety instruction will be omitted.<br/>
        /// Safety modes are not yet configurable in combination with `tools`, `tool_results` and `documents` parameters.<br/>
        /// **Note**: This parameter is only compatible with models [Command R 08-2024](/docs/command-r#august-2024-release), [Command R+ 08-2024](/docs/command-r-plus#august-2024-release) and newer.<br/>
        /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestSafetyModeJsonConverter))]
        public global::G.ChatRequestSafetyMode? SafetyMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ChatRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ChatRequest),
                jsonSerializerContext) as global::G.ChatRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChatRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ChatRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ChatRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ChatRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ChatRequest?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ChatRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}