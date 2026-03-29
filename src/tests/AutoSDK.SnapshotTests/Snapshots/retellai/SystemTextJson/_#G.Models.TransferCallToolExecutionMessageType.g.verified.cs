//HintName: G.Models.TransferCallToolExecutionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    public enum TransferCallToolExecutionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        StaticText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferCallToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferCallToolExecutionMessageType value)
        {
            return value switch
            {
                TransferCallToolExecutionMessageType.Prompt => "prompt",
                TransferCallToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferCallToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => TransferCallToolExecutionMessageType.Prompt,
                "static_text" => TransferCallToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}