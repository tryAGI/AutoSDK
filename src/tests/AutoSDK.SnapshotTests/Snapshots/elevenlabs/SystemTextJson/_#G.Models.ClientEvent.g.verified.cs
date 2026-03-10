//HintName: G.Models.ClientEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientEvent
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        AsrInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        Ping,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Interruption,
        /// <summary>
        /// 
        /// </summary>
        UserTranscript,
        /// <summary>
        /// 
        /// </summary>
        TentativeUserTranscript,
        /// <summary>
        /// 
        /// </summary>
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        AgentResponseCorrection,
        /// <summary>
        /// 
        /// </summary>
        ClientToolCall,
        /// <summary>
        /// 
        /// </summary>
        McpToolCall,
        /// <summary>
        /// 
        /// </summary>
        McpConnectionStatus,
        /// <summary>
        /// 
        /// </summary>
        AgentToolRequest,
        /// <summary>
        /// 
        /// </summary>
        AgentToolResponse,
        /// <summary>
        /// 
        /// </summary>
        AgentResponseMetadata,
        /// <summary>
        /// 
        /// </summary>
        VadScore,
        /// <summary>
        /// 
        /// </summary>
        AgentChatResponsePart,
        /// <summary>
        /// 
        /// </summary>
        ClientError,
        /// <summary>
        /// 
        /// </summary>
        GuardrailTriggered,
        /// <summary>
        /// 
        /// </summary>
        InternalTurnProbability,
        /// <summary>
        /// 
        /// </summary>
        InternalTentativeAgentResponse,
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
                ClientEvent.ConversationInitiationMetadata => "conversation_initiation_metadata",
                ClientEvent.AsrInitiationMetadata => "asr_initiation_metadata",
                ClientEvent.Ping => "ping",
                ClientEvent.Audio => "audio",
                ClientEvent.Interruption => "interruption",
                ClientEvent.UserTranscript => "user_transcript",
                ClientEvent.TentativeUserTranscript => "tentative_user_transcript",
                ClientEvent.AgentResponse => "agent_response",
                ClientEvent.AgentResponseCorrection => "agent_response_correction",
                ClientEvent.ClientToolCall => "client_tool_call",
                ClientEvent.McpToolCall => "mcp_tool_call",
                ClientEvent.McpConnectionStatus => "mcp_connection_status",
                ClientEvent.AgentToolRequest => "agent_tool_request",
                ClientEvent.AgentToolResponse => "agent_tool_response",
                ClientEvent.AgentResponseMetadata => "agent_response_metadata",
                ClientEvent.VadScore => "vad_score",
                ClientEvent.AgentChatResponsePart => "agent_chat_response_part",
                ClientEvent.ClientError => "client_error",
                ClientEvent.GuardrailTriggered => "guardrail_triggered",
                ClientEvent.InternalTurnProbability => "internal_turn_probability",
                ClientEvent.InternalTentativeAgentResponse => "internal_tentative_agent_response",
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
                "conversation_initiation_metadata" => ClientEvent.ConversationInitiationMetadata,
                "asr_initiation_metadata" => ClientEvent.AsrInitiationMetadata,
                "ping" => ClientEvent.Ping,
                "audio" => ClientEvent.Audio,
                "interruption" => ClientEvent.Interruption,
                "user_transcript" => ClientEvent.UserTranscript,
                "tentative_user_transcript" => ClientEvent.TentativeUserTranscript,
                "agent_response" => ClientEvent.AgentResponse,
                "agent_response_correction" => ClientEvent.AgentResponseCorrection,
                "client_tool_call" => ClientEvent.ClientToolCall,
                "mcp_tool_call" => ClientEvent.McpToolCall,
                "mcp_connection_status" => ClientEvent.McpConnectionStatus,
                "agent_tool_request" => ClientEvent.AgentToolRequest,
                "agent_tool_response" => ClientEvent.AgentToolResponse,
                "agent_response_metadata" => ClientEvent.AgentResponseMetadata,
                "vad_score" => ClientEvent.VadScore,
                "agent_chat_response_part" => ClientEvent.AgentChatResponsePart,
                "client_error" => ClientEvent.ClientError,
                "guardrail_triggered" => ClientEvent.GuardrailTriggered,
                "internal_turn_probability" => ClientEvent.InternalTurnProbability,
                "internal_tentative_agent_response" => ClientEvent.InternalTentativeAgentResponse,
                _ => null,
            };
        }
    }
}