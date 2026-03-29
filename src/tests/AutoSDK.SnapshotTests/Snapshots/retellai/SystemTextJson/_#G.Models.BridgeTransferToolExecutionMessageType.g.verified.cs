//HintName: G.Models.BridgeTransferToolExecutionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of execution message. "prompt" means the agent will use execution_message_description as a prompt to generate the message. "static_text" means the agent will speak the execution_message_description directly. Defaults to "prompt".
    /// </summary>
    public enum BridgeTransferToolExecutionMessageType
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
    public static class BridgeTransferToolExecutionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeTransferToolExecutionMessageType value)
        {
            return value switch
            {
                BridgeTransferToolExecutionMessageType.Prompt => "prompt",
                BridgeTransferToolExecutionMessageType.StaticText => "static_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeTransferToolExecutionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => BridgeTransferToolExecutionMessageType.Prompt,
                "static_text" => BridgeTransferToolExecutionMessageType.StaticText,
                _ => null,
            };
        }
    }
}