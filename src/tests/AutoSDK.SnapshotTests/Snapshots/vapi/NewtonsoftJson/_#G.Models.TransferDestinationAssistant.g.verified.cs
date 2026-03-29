//HintName: G.Models.TransferDestinationAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferDestinationAssistant
    {
        /// <summary>
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.OneOf<string, global::G.CustomMessage>? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TransferDestinationAssistantType Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("transferMode")]
        public global::G.TransferDestinationAssistantTransferMode? TransferMode { get; set; }

        /// <summary>
        /// This is the assistant to transfer the call to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantName", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantName { get; set; } = default!;

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationAssistant" /> class.
        /// </summary>
        /// <param name="assistantName">
        /// This is the assistant to transfer the call to.
        /// </param>
        /// <param name="message">
        /// This is spoken to the customer before connecting them to the destination.<br/>
        /// Usage:<br/>
        /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".<br/>
        /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.<br/>
        /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
        /// </param>
        /// <param name="type"></param>
        /// <param name="transferMode">
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
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
        public TransferDestinationAssistant(
            string assistantName,
            global::G.OneOf<string, global::G.CustomMessage>? message,
            global::G.TransferDestinationAssistantType type,
            global::G.TransferDestinationAssistantTransferMode? transferMode,
            string? description)
        {
            this.Message = message;
            this.Type = type;
            this.TransferMode = transferMode;
            this.AssistantName = assistantName ?? throw new global::System.ArgumentNullException(nameof(assistantName));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationAssistant" /> class.
        /// </summary>
        public TransferDestinationAssistant()
        {
        }
    }
}