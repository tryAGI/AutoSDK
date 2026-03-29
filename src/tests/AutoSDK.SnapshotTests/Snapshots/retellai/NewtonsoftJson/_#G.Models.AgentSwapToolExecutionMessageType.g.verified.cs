//HintName: G.Models.AgentSwapToolExecutionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentSwapToolExecutionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static_text")]
        StaticText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSwapToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSwapToolExecutionMessageType value)
        {
            return value switch
            {
                AgentSwapToolExecutionMessageType.Prompt => "prompt",
                AgentSwapToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSwapToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => AgentSwapToolExecutionMessageType.Prompt,
                "static_text" => AgentSwapToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}