//HintName: G.Models.ClientEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_chat_response_part")]
        AgentChatResponsePart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_response")]
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_response_correction")]
        AgentResponseCorrection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_response_metadata")]
        AgentResponseMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_tool_request")]
        AgentToolRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_tool_response")]
        AgentToolResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asr_initiation_metadata")]
        AsrInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client_error")]
        ClientError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client_tool_call")]
        ClientToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation_initiation_metadata")]
        ConversationInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="guardrail_triggered")]
        GuardrailTriggered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_tentative_agent_response")]
        InternalTentativeAgentResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_turn_probability")]
        InternalTurnProbability,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interruption")]
        Interruption,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_connection_status")]
        McpConnectionStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_tool_call")]
        McpToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ping")]
        Ping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tentative_user_transcript")]
        TentativeUserTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_transcript")]
        UserTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vad_score")]
        VadScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientEvent value)
        {
            return value switch
            {
                ClientEvent.AgentChatResponsePart => "agent_chat_response_part",
                ClientEvent.AgentResponse => "agent_response",
                ClientEvent.AgentResponseCorrection => "agent_response_correction",
                ClientEvent.AgentResponseMetadata => "agent_response_metadata",
                ClientEvent.AgentToolRequest => "agent_tool_request",
                ClientEvent.AgentToolResponse => "agent_tool_response",
                ClientEvent.AsrInitiationMetadata => "asr_initiation_metadata",
                ClientEvent.Audio => "audio",
                ClientEvent.ClientError => "client_error",
                ClientEvent.ClientToolCall => "client_tool_call",
                ClientEvent.ConversationInitiationMetadata => "conversation_initiation_metadata",
                ClientEvent.GuardrailTriggered => "guardrail_triggered",
                ClientEvent.InternalTentativeAgentResponse => "internal_tentative_agent_response",
                ClientEvent.InternalTurnProbability => "internal_turn_probability",
                ClientEvent.Interruption => "interruption",
                ClientEvent.McpConnectionStatus => "mcp_connection_status",
                ClientEvent.McpToolCall => "mcp_tool_call",
                ClientEvent.Ping => "ping",
                ClientEvent.TentativeUserTranscript => "tentative_user_transcript",
                ClientEvent.UserTranscript => "user_transcript",
                ClientEvent.VadScore => "vad_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientEvent? ToEnum(string value)
        {
            return value switch
            {
                "agent_chat_response_part" => ClientEvent.AgentChatResponsePart,
                "agent_response" => ClientEvent.AgentResponse,
                "agent_response_correction" => ClientEvent.AgentResponseCorrection,
                "agent_response_metadata" => ClientEvent.AgentResponseMetadata,
                "agent_tool_request" => ClientEvent.AgentToolRequest,
                "agent_tool_response" => ClientEvent.AgentToolResponse,
                "asr_initiation_metadata" => ClientEvent.AsrInitiationMetadata,
                "audio" => ClientEvent.Audio,
                "client_error" => ClientEvent.ClientError,
                "client_tool_call" => ClientEvent.ClientToolCall,
                "conversation_initiation_metadata" => ClientEvent.ConversationInitiationMetadata,
                "guardrail_triggered" => ClientEvent.GuardrailTriggered,
                "internal_tentative_agent_response" => ClientEvent.InternalTentativeAgentResponse,
                "internal_turn_probability" => ClientEvent.InternalTurnProbability,
                "interruption" => ClientEvent.Interruption,
                "mcp_connection_status" => ClientEvent.McpConnectionStatus,
                "mcp_tool_call" => ClientEvent.McpToolCall,
                "ping" => ClientEvent.Ping,
                "tentative_user_transcript" => ClientEvent.TentativeUserTranscript,
                "user_transcript" => ClientEvent.UserTranscript,
                "vad_score" => ClientEvent.VadScore,
                _ => null,
            };
        }
    }
}