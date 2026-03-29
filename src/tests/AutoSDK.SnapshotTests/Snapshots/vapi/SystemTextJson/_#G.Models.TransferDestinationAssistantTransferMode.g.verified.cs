//HintName: G.Models.TransferDestinationAssistantTransferMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the mode to use for the transfer. Defaults to `rolling-history`.<br/>
    /// - `rolling-history`: This is the default mode. It keeps the entire conversation history and appends the new assistant's system message on transfer.<br/>
    ///   Example:<br/>
    ///   Pre-transfer:<br/>
    ///     system: assistant1 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///   Post-transfer:<br/>
    ///     system: assistant1 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///     system: assistant2 system message<br/>
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)<br/>
    /// - `swap-system-message-in-history`: This replaces the original system message with the new assistant's system message on transfer.<br/>
    ///   Example:<br/>
    ///   Pre-transfer:<br/>
    ///     system: assistant1 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///   Post-transfer:<br/>
    ///     system: assistant2 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)<br/>
    /// - `delete-history`: This deletes the entire conversation history on transfer.<br/>
    ///   Example:<br/>
    ///   Pre-transfer:<br/>
    ///     system: assistant1 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///   Post-transfer:<br/>
    ///     system: assistant2 system message<br/>
    ///     assistant: assistant2 first message<br/>
    ///     user: Yes, please<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    /// - `swap-system-message-in-history-and-remove-transfer-tool-messages`: This replaces the original system message with the new assistant's system message on transfer and removes transfer tool messages from conversation history sent to the LLM.<br/>
    ///   Example:<br/>
    ///   Pre-transfer:<br/>
    ///     system: assistant1 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     transfer-tool<br/>
    ///     transfer-tool-result<br/>
    ///     assistant: (destination.message)<br/>
    ///   Post-transfer:<br/>
    ///     system: assistant2 system message<br/>
    ///     assistant: assistant1 first message<br/>
    ///     user: hey, good morning<br/>
    ///     assistant: how can i help?<br/>
    ///     user: i need help with my account<br/>
    ///     assistant: (destination.message)<br/>
    ///     assistant: assistant2 first message (or model generated if firstMessageMode is set to `assistant-speaks-first-with-model-generated-message`)<br/>
    /// @default 'rolling-history'
    /// </summary>
    public enum TransferDestinationAssistantTransferMode
    {
        /// <summary>
        /// This deletes the entire conversation history on transfer.
        /// </summary>
        DeleteHistory,
        /// <summary>
        /// This is the default mode. It keeps the entire conversation history and appends the new assistant's system message on transfer.
        /// </summary>
        RollingHistory,
        /// <summary>
        /// This replaces the original system message with the new assistant's system message on transfer.
        /// </summary>
        SwapSystemMessageInHistory,
        /// <summary>
        /// This replaces the original system message with the new assistant's system message on transfer and removes transfer tool messages from conversation history sent to the LLM.
        /// </summary>
        SwapSystemMessageInHistoryAndRemoveTransferToolMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationAssistantTransferModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationAssistantTransferMode value)
        {
            return value switch
            {
                TransferDestinationAssistantTransferMode.DeleteHistory => "delete-history",
                TransferDestinationAssistantTransferMode.RollingHistory => "rolling-history",
                TransferDestinationAssistantTransferMode.SwapSystemMessageInHistory => "swap-system-message-in-history",
                TransferDestinationAssistantTransferMode.SwapSystemMessageInHistoryAndRemoveTransferToolMessages => "swap-system-message-in-history-and-remove-transfer-tool-messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationAssistantTransferMode? ToEnum(string value)
        {
            return value switch
            {
                "delete-history" => TransferDestinationAssistantTransferMode.DeleteHistory,
                "rolling-history" => TransferDestinationAssistantTransferMode.RollingHistory,
                "swap-system-message-in-history" => TransferDestinationAssistantTransferMode.SwapSystemMessageInHistory,
                "swap-system-message-in-history-and-remove-transfer-tool-messages" => TransferDestinationAssistantTransferMode.SwapSystemMessageInHistoryAndRemoveTransferToolMessages,
                _ => null,
            };
        }
    }
}