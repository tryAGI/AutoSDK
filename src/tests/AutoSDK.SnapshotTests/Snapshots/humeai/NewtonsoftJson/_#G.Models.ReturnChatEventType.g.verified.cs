//HintName: G.Models.ReturnChatEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnChatEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_MESSAGE")]
        AgentMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FUNCTION_CALL")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FUNCTION_CALL_RESPONSE")]
        FunctionCallResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM_PROMPT")]
        SystemPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER_INTERRUPTION")]
        UserInterruption,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER_MESSAGE")]
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatEventType value)
        {
            return value switch
            {
                ReturnChatEventType.AgentMessage => "AGENT_MESSAGE",
                ReturnChatEventType.FunctionCall => "FUNCTION_CALL",
                ReturnChatEventType.FunctionCallResponse => "FUNCTION_CALL_RESPONSE",
                ReturnChatEventType.SystemPrompt => "SYSTEM_PROMPT",
                ReturnChatEventType.UserInterruption => "USER_INTERRUPTION",
                ReturnChatEventType.UserMessage => "USER_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatEventType? ToEnum(string value)
        {
            return value switch
            {
                "AGENT_MESSAGE" => ReturnChatEventType.AgentMessage,
                "FUNCTION_CALL" => ReturnChatEventType.FunctionCall,
                "FUNCTION_CALL_RESPONSE" => ReturnChatEventType.FunctionCallResponse,
                "SYSTEM_PROMPT" => ReturnChatEventType.SystemPrompt,
                "USER_INTERRUPTION" => ReturnChatEventType.UserInterruption,
                "USER_MESSAGE" => ReturnChatEventType.UserMessage,
                _ => null,
            };
        }
    }
}