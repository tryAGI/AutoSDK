//HintName: G.Models.CustomLLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLLMModel
    {
        /// <summary>
        /// This is the starting state for the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage>? Messages { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? Tools { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// These are the options for the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledgeBase")]
        public global::G.CreateCustomKnowledgeBaseDTO? KnowledgeBase { get; set; }

        /// <summary>
        /// This is the provider that will be used for the model. Any service, including your own server, that is compatible with the OpenAI API can be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomLLMModelProviderJsonConverter))]
        public global::G.CustomLLMModelProvider Provider { get; set; }

        /// <summary>
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadataSendMode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomLLMModelMetadataSendModeJsonConverter))]
        public global::G.CustomLLMModelMetadataSendMode? MetadataSendMode { get; set; }

        /// <summary>
        /// Custom headers to send with requests. These headers can override default OpenAI headers except for Authorization (which should be specified using a custom-llm credential).<br/>
        /// Example: {"X-Custom-Header":"value"}
        /// </summary>
        /// <example>{"X-Custom-Header":"value"}</example>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// This determines whether the transcriber's word level confidence is sent in requests to the custom provider. Default is false.<br/>
        /// This only works for Deepgram transcribers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordLevelConfidenceEnabled")]
        public bool? WordLevelConfidenceEnabled { get; set; }

        /// <summary>
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.<br/>
        /// Default `false` because the model is usually are good at understanding the user's emotion from text.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotionRecognitionEnabled")]
        public bool? EmotionRecognitionEnabled { get; set; }

        /// <summary>
        /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.<br/>
        /// Default is 0.<br/>
        /// @default 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numFastTurns")]
        public double? NumFastTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLMModel" /> class.
        /// </summary>
        /// <param name="url">
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </param>
        /// <param name="model">
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </param>
        /// <param name="messages">
        /// This is the starting state for the conversation.
        /// </param>
        /// <param name="tools">
        /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="toolIds">
        /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="knowledgeBase">
        /// These are the options for the knowledge base.
        /// </param>
        /// <param name="provider">
        /// This is the provider that will be used for the model. Any service, including your own server, that is compatible with the OpenAI API can be used.
        /// </param>
        /// <param name="metadataSendMode">
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </param>
        /// <param name="headers">
        /// Custom headers to send with requests. These headers can override default OpenAI headers except for Authorization (which should be specified using a custom-llm credential).<br/>
        /// Example: {"X-Custom-Header":"value"}
        /// </param>
        /// <param name="wordLevelConfidenceEnabled">
        /// This determines whether the transcriber's word level confidence is sent in requests to the custom provider. Default is false.<br/>
        /// This only works for Deepgram transcribers.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
        /// </param>
        /// <param name="emotionRecognitionEnabled">
        /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.<br/>
        /// Default `false` because the model is usually are good at understanding the user's emotion from text.<br/>
        /// @default false
        /// </param>
        /// <param name="numFastTurns">
        /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.<br/>
        /// Default is 0.<br/>
        /// @default 0
        /// </param>
        public CustomLLMModel(
            string url,
            string model,
            global::System.Collections.Generic.IList<global::G.OpenAIMessage>? messages,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::G.CreateCustomKnowledgeBaseDTO? knowledgeBase,
            global::G.CustomLLMModelProvider provider,
            global::G.CustomLLMModelMetadataSendMode? metadataSendMode,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? wordLevelConfidenceEnabled,
            double? timeoutSeconds,
            double? temperature,
            double? maxTokens,
            bool? emotionRecognitionEnabled,
            double? numFastTurns)
        {
            this.Messages = messages;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.KnowledgeBase = knowledgeBase;
            this.Provider = provider;
            this.MetadataSendMode = metadataSendMode;
            this.Headers = headers;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.WordLevelConfidenceEnabled = wordLevelConfidenceEnabled;
            this.TimeoutSeconds = timeoutSeconds;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.EmotionRecognitionEnabled = emotionRecognitionEnabled;
            this.NumFastTurns = numFastTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLMModel" /> class.
        /// </summary>
        public CustomLLMModel()
        {
        }
    }
}