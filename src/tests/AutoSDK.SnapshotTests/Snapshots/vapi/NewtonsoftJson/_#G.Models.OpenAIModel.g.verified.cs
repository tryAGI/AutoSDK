//HintName: G.Models.OpenAIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIModel
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
        /// This is the provider that will be used for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.OpenAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.<br/>
        /// @default undefined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIModelModel Model { get; set; } = default!;

        /// <summary>
        /// These are the fallback models that will be used if the primary model fails. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest fallbacks that make sense.<br/>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::Newtonsoft.Json.JsonProperty("fallbackModels")]
        public global::System.Collections.Generic.IList<global::G.OpenAIModelFallbackModel>? FallbackModels { get; set; }

        /// <summary>
        /// Azure OpenAI doesn't support `maxLength` right now https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/structured-outputs?tabs=python-secure%2Cdotnet-entra-id&amp;pivots=programming-language-csharp#unsupported-type-specific-keywords. Need to strip.<br/>
        /// - `strip-parameters-with-unsupported-validation` will strip parameters with unsupported validation.<br/>
        /// - `strip-unsupported-validation` will keep the parameters but strip unsupported validation.<br/>
        /// @default `strip-unsupported-validation`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolStrictCompatibilityMode")]
        public global::G.OpenAIModelToolStrictCompatibilityMode? ToolStrictCompatibilityMode { get; set; }

        /// <summary>
        /// This controls the prompt cache retention policy for models that support extended caching (GPT-4.1, GPT-5 series).<br/>
        /// - `in_memory`: Default behavior, cache retained in GPU memory only<br/>
        /// - `24h`: Extended caching, keeps cached prefixes active for up to 24 hours by offloading to GPU-local storage<br/>
        /// Only applies to models: gpt-5.2, gpt-5.1, gpt-5.1-codex, gpt-5.1-codex-mini, gpt-5.1-chat-latest, gpt-5, gpt-5-codex, gpt-4.1<br/>
        /// @default undefined (uses API default which is 'in_memory')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptCacheRetention")]
        public global::G.OpenAIModelPromptCacheRetention? PromptCacheRetention { get; set; }

        /// <summary>
        /// This is the prompt cache key for models that support extended caching (GPT-4.1, GPT-5 series).<br/>
        /// Providing a cache key allows you to share cached prefixes across requests.<br/>
        /// @default undefined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptCacheKey")]
        public string? PromptCacheKey { get; set; }

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
        /// Initializes a new instance of the <see cref="OpenAIModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.<br/>
        /// @default undefined
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
        /// This is the provider that will be used for the model.
        /// </param>
        /// <param name="fallbackModels">
        /// These are the fallback models that will be used if the primary model fails. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest fallbacks that make sense.<br/>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </param>
        /// <param name="toolStrictCompatibilityMode">
        /// Azure OpenAI doesn't support `maxLength` right now https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/structured-outputs?tabs=python-secure%2Cdotnet-entra-id&amp;pivots=programming-language-csharp#unsupported-type-specific-keywords. Need to strip.<br/>
        /// - `strip-parameters-with-unsupported-validation` will strip parameters with unsupported validation.<br/>
        /// - `strip-unsupported-validation` will keep the parameters but strip unsupported validation.<br/>
        /// @default `strip-unsupported-validation`
        /// </param>
        /// <param name="promptCacheRetention">
        /// This controls the prompt cache retention policy for models that support extended caching (GPT-4.1, GPT-5 series).<br/>
        /// - `in_memory`: Default behavior, cache retained in GPU memory only<br/>
        /// - `24h`: Extended caching, keeps cached prefixes active for up to 24 hours by offloading to GPU-local storage<br/>
        /// Only applies to models: gpt-5.2, gpt-5.1, gpt-5.1-codex, gpt-5.1-codex-mini, gpt-5.1-chat-latest, gpt-5, gpt-5-codex, gpt-4.1<br/>
        /// @default undefined (uses API default which is 'in_memory')
        /// </param>
        /// <param name="promptCacheKey">
        /// This is the prompt cache key for models that support extended caching (GPT-4.1, GPT-5 series).<br/>
        /// Providing a cache key allows you to share cached prefixes across requests.<br/>
        /// @default undefined
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
        public OpenAIModel(
            global::G.OpenAIModelModel model,
            global::System.Collections.Generic.IList<global::G.OpenAIMessage>? messages,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::G.CreateCustomKnowledgeBaseDTO? knowledgeBase,
            global::G.OpenAIModelProvider provider,
            global::System.Collections.Generic.IList<global::G.OpenAIModelFallbackModel>? fallbackModels,
            global::G.OpenAIModelToolStrictCompatibilityMode? toolStrictCompatibilityMode,
            global::G.OpenAIModelPromptCacheRetention? promptCacheRetention,
            string? promptCacheKey,
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
            this.Model = model;
            this.FallbackModels = fallbackModels;
            this.ToolStrictCompatibilityMode = toolStrictCompatibilityMode;
            this.PromptCacheRetention = promptCacheRetention;
            this.PromptCacheKey = promptCacheKey;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.EmotionRecognitionEnabled = emotionRecognitionEnabled;
            this.NumFastTurns = numFastTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModel" /> class.
        /// </summary>
        public OpenAIModel()
        {
        }
    }
}