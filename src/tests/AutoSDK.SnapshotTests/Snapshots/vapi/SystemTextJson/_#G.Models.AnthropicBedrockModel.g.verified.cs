//HintName: G.Models.AnthropicBedrockModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicBedrockModel
    {
        /// <summary>
        /// This is the starting state for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage>? Messages { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? Tools { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// These are the options for the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBase")]
        public global::G.CreateCustomKnowledgeBaseDTO? KnowledgeBase { get; set; }

        /// <summary>
        /// The provider identifier for Anthropic via AWS Bedrock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicBedrockModelProviderJsonConverter))]
        public global::G.AnthropicBedrockModelProvider Provider { get; set; }

        /// <summary>
        /// The specific Anthropic/Claude model that will be used via Bedrock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicBedrockModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnthropicBedrockModelModel Model { get; set; }

        /// <summary>
        /// Optional configuration for Anthropic's thinking feature.<br/>
        /// Only applicable for claude-3-7-sonnet-20250219 model.<br/>
        /// If provided, maxTokens must be greater than thinking.budgetTokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::G.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.<br/>
        /// Default `false` because the model is usually are good at understanding the user's emotion from text.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotionRecognitionEnabled")]
        public bool? EmotionRecognitionEnabled { get; set; }

        /// <summary>
        /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.<br/>
        /// Default is 0.<br/>
        /// @default 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numFastTurns")]
        public double? NumFastTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBedrockModel" /> class.
        /// </summary>
        /// <param name="model">
        /// The specific Anthropic/Claude model that will be used via Bedrock.
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
        /// The provider identifier for Anthropic via AWS Bedrock.
        /// </param>
        /// <param name="thinking">
        /// Optional configuration for Anthropic's thinking feature.<br/>
        /// Only applicable for claude-3-7-sonnet-20250219 model.<br/>
        /// If provided, maxTokens must be greater than thinking.budgetTokens.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicBedrockModel(
            global::G.AnthropicBedrockModelModel model,
            global::System.Collections.Generic.IList<global::G.OpenAIMessage>? messages,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateApiRequestToolDTO, global::G.CreateBashToolDTO, global::G.CreateCodeToolDTO, global::G.CreateComputerToolDTO, global::G.CreateDtmfToolDTO, global::G.CreateEndCallToolDTO, global::G.CreateFunctionToolDTO, global::G.CreateGoHighLevelCalendarAvailabilityToolDTO, global::G.CreateGoHighLevelCalendarEventCreateToolDTO, global::G.CreateGoHighLevelContactCreateToolDTO, global::G.CreateGoHighLevelContactGetToolDTO, global::G.CreateGoogleCalendarCheckAvailabilityToolDTO, global::G.CreateGoogleCalendarCreateEventToolDTO, global::G.CreateGoogleSheetsRowAppendToolDTO, global::G.CreateHandoffToolDTO, global::G.CreateMcpToolDTO, global::G.CreateQueryToolDTO, global::G.CreateSlackSendMessageToolDTO, global::G.CreateSmsToolDTO, global::G.CreateTextEditorToolDTO, global::G.CreateTransferCallToolDTO, global::G.CreateSipRequestToolDTO, global::G.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::G.CreateCustomKnowledgeBaseDTO? knowledgeBase,
            global::G.AnthropicBedrockModelProvider provider,
            global::G.AnthropicThinkingConfig? thinking,
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
            this.Thinking = thinking;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.EmotionRecognitionEnabled = emotionRecognitionEnabled;
            this.NumFastTurns = numFastTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBedrockModel" /> class.
        /// </summary>
        public AnthropicBedrockModel()
        {
        }
    }
}