//HintName: G.Models.CancelTransferToolExecutionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    public enum CancelTransferToolExecutionMessageType
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
    public static class CancelTransferToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelTransferToolExecutionMessageType value)
        {
            return value switch
            {
                CancelTransferToolExecutionMessageType.Prompt => "prompt",
                CancelTransferToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelTransferToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => CancelTransferToolExecutionMessageType.Prompt,
                "static_text" => CancelTransferToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}