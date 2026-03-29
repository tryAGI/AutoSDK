//HintName: G.Models.RetellLlmOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override properties for Retell LLM configuration in agent override requests.
    /// </summary>
    public sealed partial class RetellLlmOverride
    {
        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NullableLLMModelJsonConverter))]
        public global::G.NullableLLMModel? Model { get; set; }

        /// <summary>
        /// Select the underlying speech to speech model. Can only set this or model, not both.<br/>
        /// Example: gpt-realtime-1.5
        /// </summary>
        /// <example>gpt-realtime-1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("s2s_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetellLlmOverrideS2sModelJsonConverter))]
        public global::G.RetellLlmOverrideS2sModel? S2sModel { get; set; }

        /// <summary>
        /// If set, will control the randomness of the response. Value ranging from [0,1]. Lower value means more deterministic, while higher value means more random. If unset, default value 0 will apply. Note that for tool calling, a lower value is recommended.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_temperature")]
        public double? ModelTemperature { get; set; }

        /// <summary>
        /// If set to true, will use high priority pool with more dedicated resource to ensure lower and more consistent latency, default to false. This feature usually comes with a higher cost.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_high_priority")]
        public bool? ModelHighPriority { get; set; }

        /// <summary>
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_strict_mode")]
        public bool? ToolCallStrictMode { get; set; }

        /// <summary>
        /// A list of knowledge base ids to use for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_config")]
        public global::G.KBConfig? KbConfig { get; set; }

        /// <summary>
        /// The speaker who starts the conversation. Required. Must be either 'user' or 'agent'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetellLlmOverrideStartSpeakerJsonConverter))]
        public global::G.RetellLlmOverrideStartSpeaker? StartSpeaker { get; set; }

        /// <summary>
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_after_user_silence_ms")]
        public int? BeginAfterUserSilenceMs { get; set; }

        /// <summary>
        /// First utterance said by the agent in the call. If not set, LLM will dynamically generate a message. If set to "", agent will wait for user to speak first.<br/>
        /// Example: Hey I am a virtual assistant calling from Retell Hospital.
        /// </summary>
        /// <example>Hey I am a virtual assistant calling from Retell Hospital.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_message")]
        public string? BeginMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmOverride" /> class.
        /// </summary>
        /// <param name="model">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="s2sModel">
        /// Select the underlying speech to speech model. Can only set this or model, not both.<br/>
        /// Example: gpt-realtime-1.5
        /// </param>
        /// <param name="modelTemperature">
        /// If set, will control the randomness of the response. Value ranging from [0,1]. Lower value means more deterministic, while higher value means more random. If unset, default value 0 will apply. Note that for tool calling, a lower value is recommended.<br/>
        /// Example: 0
        /// </param>
        /// <param name="modelHighPriority">
        /// If set to true, will use high priority pool with more dedicated resource to ensure lower and more consistent latency, default to false. This feature usually comes with a higher cost.<br/>
        /// Example: true
        /// </param>
        /// <param name="toolCallStrictMode">
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// A list of knowledge base ids to use for this resource.
        /// </param>
        /// <param name="kbConfig"></param>
        /// <param name="startSpeaker">
        /// The speaker who starts the conversation. Required. Must be either 'user' or 'agent'.
        /// </param>
        /// <param name="beginAfterUserSilenceMs">
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="beginMessage">
        /// First utterance said by the agent in the call. If not set, LLM will dynamically generate a message. If set to "", agent will wait for user to speak first.<br/>
        /// Example: Hey I am a virtual assistant calling from Retell Hospital.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetellLlmOverride(
            global::G.NullableLLMModel? model,
            global::G.RetellLlmOverrideS2sModel? s2sModel,
            double? modelTemperature,
            bool? modelHighPriority,
            bool? toolCallStrictMode,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::G.KBConfig? kbConfig,
            global::G.RetellLlmOverrideStartSpeaker? startSpeaker,
            int? beginAfterUserSilenceMs,
            string? beginMessage)
        {
            this.Model = model;
            this.S2sModel = s2sModel;
            this.ModelTemperature = modelTemperature;
            this.ModelHighPriority = modelHighPriority;
            this.ToolCallStrictMode = toolCallStrictMode;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.KbConfig = kbConfig;
            this.StartSpeaker = startSpeaker;
            this.BeginAfterUserSilenceMs = beginAfterUserSilenceMs;
            this.BeginMessage = beginMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmOverride" /> class.
        /// </summary>
        public RetellLlmOverride()
        {
        }
    }
}