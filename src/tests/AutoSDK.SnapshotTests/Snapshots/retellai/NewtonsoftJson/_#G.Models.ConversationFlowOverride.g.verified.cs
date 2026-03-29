//HintName: G.Models.ConversationFlowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override properties for conversation flow configuration in agent override requests.
    /// </summary>
    public sealed partial class ConversationFlowOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_choice")]
        public global::G.ModelChoiceCascading? ModelChoice { get; set; }

        /// <summary>
        /// Controls the randomness of the model's responses. Lower values make responses more deterministic.<br/>
        /// Example: 0.7
        /// </summary>
        /// <example>0.7</example>
        [global::Newtonsoft.Json.JsonProperty("model_temperature")]
        public double? ModelTemperature { get; set; }

        /// <summary>
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("tool_call_strict_mode")]
        public bool? ToolCallStrictMode { get; set; }

        /// <summary>
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </summary>
        /// <example>[kb_001, kb_002]</example>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kb_config")]
        public global::G.KBConfig? KbConfig { get; set; }

        /// <summary>
        /// Who starts the conversation - user or agent.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::Newtonsoft.Json.JsonProperty("start_speaker")]
        public global::G.ConversationFlowOverrideStartSpeaker? StartSpeaker { get; set; }

        /// <summary>
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::Newtonsoft.Json.JsonProperty("begin_after_user_silence_ms")]
        public int? BeginAfterUserSilenceMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowOverride" /> class.
        /// </summary>
        /// <param name="modelChoice"></param>
        /// <param name="modelTemperature">
        /// Controls the randomness of the model's responses. Lower values make responses more deterministic.<br/>
        /// Example: 0.7
        /// </param>
        /// <param name="toolCallStrictMode">
        /// Whether to use strict mode for tool calls. Only applicable when using certain supported models.<br/>
        /// Example: true
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// Knowledge base IDs for RAG (Retrieval-Augmented Generation).<br/>
        /// Example: [kb_001, kb_002]
        /// </param>
        /// <param name="kbConfig"></param>
        /// <param name="startSpeaker">
        /// Who starts the conversation - user or agent.<br/>
        /// Example: agent
        /// </param>
        /// <param name="beginAfterUserSilenceMs">
        /// If set, the AI will begin the conversation after waiting for the user for the duration (in milliseconds) specified by this attribute. This only applies if the agent is configured to wait for the user to speak first. If not set, the agent will wait indefinitely for the user to speak.<br/>
        /// Example: 2000
        /// </param>
        public ConversationFlowOverride(
            global::G.ModelChoiceCascading? modelChoice,
            double? modelTemperature,
            bool? toolCallStrictMode,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::G.KBConfig? kbConfig,
            global::G.ConversationFlowOverrideStartSpeaker? startSpeaker,
            int? beginAfterUserSilenceMs)
        {
            this.ModelChoice = modelChoice;
            this.ModelTemperature = modelTemperature;
            this.ToolCallStrictMode = toolCallStrictMode;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.KbConfig = kbConfig;
            this.StartSpeaker = startSpeaker;
            this.BeginAfterUserSilenceMs = beginAfterUserSilenceMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationFlowOverride" /> class.
        /// </summary>
        public ConversationFlowOverride()
        {
        }
    }
}