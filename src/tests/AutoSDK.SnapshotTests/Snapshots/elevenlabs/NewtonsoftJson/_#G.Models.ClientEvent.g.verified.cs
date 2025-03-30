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
        [global::System.Runtime.Serialization.EnumMember(Value="conversation_initiation_metadata")]
        ConversationInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asr_initiation_metadata")]
        AsrInitiationMetadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ping")]
        Ping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interruption")]
        Interruption,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_transcript")]
        UserTranscript,
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
        [global::System.Runtime.Serialization.EnumMember(Value="client_tool_call")]
        ClientToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_vad_score")]
        InternalVadScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_turn_probability")]
        InternalTurnProbability,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_tentative_agent_response")]
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
                ClientEvent.AgentResponse => "agent_response",
                ClientEvent.AgentResponseCorrection => "agent_response_correction",
                ClientEvent.ClientToolCall => "client_tool_call",
                ClientEvent.InternalVadScore => "internal_vad_score",
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
                "agent_response" => ClientEvent.AgentResponse,
                "agent_response_correction" => ClientEvent.AgentResponseCorrection,
                "client_tool_call" => ClientEvent.ClientToolCall,
                "internal_vad_score" => ClientEvent.InternalVadScore,
                "internal_turn_probability" => ClientEvent.InternalTurnProbability,
                "internal_tentative_agent_response" => ClientEvent.InternalTentativeAgentResponse,
                _ => null,
            };
        }
    }
}