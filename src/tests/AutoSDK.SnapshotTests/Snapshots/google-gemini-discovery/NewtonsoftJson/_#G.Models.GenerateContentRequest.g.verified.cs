//HintName: G.Models.GenerateContentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to generate a completion from the model.
    /// </summary>
    public sealed partial class GenerateContentRequest
    {
        /// <summary>
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemInstruction")]
        public global::G.Content? SystemInstruction { get; set; }

        /// <summary>
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.Content>? Contents { get; set; }

        /// <summary>
        /// Optional. A list of `Tools` the `Model` may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? Tools { get; set; }

        /// <summary>
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolConfig")]
        public global::G.ToolConfig? ToolConfig { get; set; }

        /// <summary>
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safetySettings")]
        public global::System.Collections.Generic.IList<global::G.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generationConfig")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedContent")]
        public string? CachedContent { get; set; }

        /// <summary>
        /// Optional. The service tier of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serviceTier")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerateContentRequestServiceTierJsonConverter))]
        public global::G.GenerateContentRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Optional. Configures the logging behavior for a given request. If set, it takes precedence over the project-level logging config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
        /// </param>
        /// <param name="tools">
        /// Optional. A list of `Tools` the `Model` may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </param>
        /// <param name="cachedContent">
        /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
        /// </param>
        /// <param name="serviceTier">
        /// Optional. The service tier of the request.
        /// </param>
        /// <param name="store">
        /// Optional. Configures the logging behavior for a given request. If set, it takes precedence over the project-level logging config.
        /// </param>
        public GenerateContentRequest(
            string? model,
            global::G.Content? systemInstruction,
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.ToolConfig? toolConfig,
            global::System.Collections.Generic.IList<global::G.SafetySetting>? safetySettings,
            global::G.GenerationConfig? generationConfig,
            string? cachedContent,
            global::G.GenerateContentRequestServiceTier? serviceTier,
            bool? store)
        {
            this.Model = model;
            this.SystemInstruction = systemInstruction;
            this.Contents = contents;
            this.Tools = tools;
            this.ToolConfig = toolConfig;
            this.SafetySettings = safetySettings;
            this.GenerationConfig = generationConfig;
            this.CachedContent = cachedContent;
            this.ServiceTier = serviceTier;
            this.Store = store;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        public GenerateContentRequest()
        {
        }
    }
}