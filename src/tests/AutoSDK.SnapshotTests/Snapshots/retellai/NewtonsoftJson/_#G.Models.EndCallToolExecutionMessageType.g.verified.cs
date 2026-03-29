//HintName: G.Models.EndCallToolExecutionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EndCallToolExecutionMessageType
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
    public static class EndCallToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndCallToolExecutionMessageType value)
        {
            return value switch
            {
                EndCallToolExecutionMessageType.Prompt => "prompt",
                EndCallToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndCallToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => EndCallToolExecutionMessageType.Prompt,
                "static_text" => EndCallToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}