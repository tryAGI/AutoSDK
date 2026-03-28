//HintName: G.Models.WorkflowOverrideAgentNodeModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowOverrideAgentNodeModelInput
    {
        /// <summary>
        /// Configuration overrides applied while the subagent is conducting the conversation.<br/>
        /// Example: {"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}
        /// </summary>
        /// <example>{"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}</example>
        [global::Newtonsoft.Json.JsonProperty("conversation_config")]
        public global::G.ConversationalConfigAPIModelWorkflowOverrideInput? ConversationConfig { get; set; }

        /// <summary>
        /// Specific goal for this subagent. It will be added to the system prompt and can be used to further refine the agent's behavior in this specific context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_prompt")]
        public string? AdditionalPrompt { get; set; }

        /// <summary>
        /// Additional knowledge base documents that the subagent has access to. These will be used in addition to the main agent's documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_knowledge_base")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? AdditionalKnowledgeBase { get; set; }

        /// <summary>
        /// IDs of additional tools that the subagent has access to. These will be used in addition to the main agent's tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_tool_ids")]
        public global::System.Collections.Generic.IList<string>? AdditionalToolIds { get; set; }

        /// <summary>
        /// Default Value: override_agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public global::G.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

        /// <summary>
        /// Human-readable label for the node used throughout the UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrideAgentNodeModelInput" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label for the node used throughout the UI.
        /// </param>
        /// <param name="conversationConfig">
        /// Configuration overrides applied while the subagent is conducting the conversation.<br/>
        /// Example: {"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}
        /// </param>
        /// <param name="additionalPrompt">
        /// Specific goal for this subagent. It will be added to the system prompt and can be used to further refine the agent's behavior in this specific context.
        /// </param>
        /// <param name="additionalKnowledgeBase">
        /// Additional knowledge base documents that the subagent has access to. These will be used in addition to the main agent's documents.
        /// </param>
        /// <param name="additionalToolIds">
        /// IDs of additional tools that the subagent has access to. These will be used in addition to the main agent's tools.
        /// </param>
        /// <param name="type">
        /// Default Value: override_agent
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        public WorkflowOverrideAgentNodeModelInput(
            string label,
            global::G.ConversationalConfigAPIModelWorkflowOverrideInput? conversationConfig,
            string? additionalPrompt,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? additionalKnowledgeBase,
            global::System.Collections.Generic.IList<string>? additionalToolIds,
            string? type,
            global::G.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder)
        {
            this.ConversationConfig = conversationConfig;
            this.AdditionalPrompt = additionalPrompt;
            this.AdditionalKnowledgeBase = additionalKnowledgeBase;
            this.AdditionalToolIds = additionalToolIds;
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrideAgentNodeModelInput" /> class.
        /// </summary>
        public WorkflowOverrideAgentNodeModelInput()
        {
        }
    }
}