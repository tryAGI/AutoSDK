//HintName: G.Models.WorkflowOverrideAgentNodeModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowOverrideAgentNodeModelOutput
    {
        /// <summary>
        /// Configuration overrides applied while the subagent is conducting the conversation.<br/>
        /// Example: {"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}
        /// </summary>
        /// <example>{"agent":{"disable_first_message_interruptions":false,"dynamic_variables":{"dynamic_variable_placeholders":{"user_name":"John Doe"}},"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0.0,"tool_ids":[],"tools":[]}},"asr":{"keywords":["hello","world"],"provider":"elevenlabs","quality":"high","user_input_audio_format":"pcm_16000"},"conversation":{"client_events":["audio","interruption"],"max_duration_seconds":600},"tts":{"agent_output_audio_format":"pcm_16000","model_id":"eleven_turbo_v2","optimize_streaming_latency":3,"pronunciation_dictionary_locators":[],"similarity_boost":0.8,"speed":1.0,"stability":0.5,"voice_id":"cjVigY5qzO86Huf0OWal"},"turn":{"mode":"turn","silence_end_call_timeout":-1.0,"soft_timeout_config":{"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false},"speculative_turn":false,"spelling_patience":"auto","turn_eagerness":"normal","turn_timeout":7.0},"vad":{"background_voice_detection":false}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationalConfigAPIModelWorkflowOverrideOutput ConversationConfig { get; set; }

        /// <summary>
        /// Specific goal for this subagent. It will be added to the system prompt and can be used to further refine the agent's behavior in this specific context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdditionalPrompt { get; set; }

        /// <summary>
        /// Additional knowledge base documents that the subagent has access to. These will be used in addition to the main agent's documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_knowledge_base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator> AdditionalKnowledgeBase { get; set; }

        /// <summary>
        /// IDs of additional tools that the subagent has access to. These will be used in addition to the main agent's tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_tool_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AdditionalToolIds { get; set; }

        /// <summary>
        /// Default Value: override_agent
        /// </summary>
        /// <default>"override_agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "override_agent";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PositionOutput Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EdgeOrder { get; set; }

        /// <summary>
        /// Human-readable label for the node used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrideAgentNodeModelOutput" /> class.
        /// </summary>
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
        /// <param name="label">
        /// Human-readable label for the node used throughout the UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowOverrideAgentNodeModelOutput(
            global::G.ConversationalConfigAPIModelWorkflowOverrideOutput conversationConfig,
            string additionalPrompt,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator> additionalKnowledgeBase,
            global::System.Collections.Generic.IList<string> additionalToolIds,
            global::G.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            string label,
            string type = "override_agent")
        {
            this.ConversationConfig = conversationConfig ?? throw new global::System.ArgumentNullException(nameof(conversationConfig));
            this.AdditionalPrompt = additionalPrompt ?? throw new global::System.ArgumentNullException(nameof(additionalPrompt));
            this.AdditionalKnowledgeBase = additionalKnowledgeBase ?? throw new global::System.ArgumentNullException(nameof(additionalKnowledgeBase));
            this.AdditionalToolIds = additionalToolIds ?? throw new global::System.ArgumentNullException(nameof(additionalToolIds));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrideAgentNodeModelOutput" /> class.
        /// </summary>
        public WorkflowOverrideAgentNodeModelOutput()
        {
        }
    }
}