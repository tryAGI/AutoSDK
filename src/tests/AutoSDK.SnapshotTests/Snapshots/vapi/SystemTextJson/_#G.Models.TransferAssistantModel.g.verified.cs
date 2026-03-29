//HintName: G.Models.TransferAssistantModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferAssistantModel
    {
        /// <summary>
        /// The model provider for the transfer assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TransferAssistantModelProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TransferAssistantModelProvider Provider { get; set; }

        /// <summary>
        /// The model name - must be compatible with the selected provider<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// These are the messages used to configure the transfer assistant.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     role: 'system',<br/>
        ///     content: 'You are a transfer assistant designed to facilitate call transfers. Your core responsibility is to manage the transfer process efficiently.\n\n## Core Responsibility\n- Facilitate the transfer process by using transferSuccessful or transferCancel tools appropriately\n\n## When to Respond\n- Answer questions about the transfer process or provide summaries when specifically asked by the operator\n- Respond to direct questions about the current transfer situation\n\n## What to Avoid\n- Do not discuss topics unrelated to the transfer\n- Do not engage in general conversation\n- Keep all interactions focused on facilitating the transfer\n\n## Transfer Tools\n- Use transferSuccessful when the transfer should proceed\n- Use transferCancel when the transfer cannot be completed\n\nStay focused on your core responsibility of facilitating transfers.'<br/>
        ///   }<br/>
        /// ]```<br/>
        /// **Default Behavior:** If you don't provide any messages or don't include a system message as the first message, the default system message above will be automatically added.<br/>
        /// **Override Default:** To replace the default system message, provide your own system message as the first message in the array.<br/>
        /// **Add Context:** You can provide additional messages (user, assistant, etc.) to add context while keeping the default system message, or combine them with your custom system message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public byte[]? Messages { get; set; }

        /// <summary>
        /// Tools available to the transfer assistant during warm-transfer-experimental.<br/>
        /// **Default Behavior:** The transfer assistant will ALWAYS have both `transferSuccessful` and `transferCancel` tools automatically added, regardless of what you provide here.<br/>
        /// **Default Tools:**<br/>
        /// - `transferSuccessful`: "Call this function to confirm the transfer is successful and connect the customer. Use this when you detect a human has answered and is ready to take the call."<br/>
        /// - `transferCancel`: "Call this function to cancel the transfer when no human answers or transfer should not proceed. Use this when you detect voicemail, busy signal, or no answer."<br/>
        /// **Customization:** You can override the default tools by providing `transferSuccessful` and/or `transferCancel` tools with custom `function` or `messages` configurations.<br/>
        /// **Additional Tools:** You can also provide other tools, but the two transfer tools will always be present and available to the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public byte[]? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssistantModel" /> class.
        /// </summary>
        /// <param name="provider">
        /// The model provider for the transfer assistant
        /// </param>
        /// <param name="model">
        /// The model name - must be compatible with the selected provider<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="messages">
        /// These are the messages used to configure the transfer assistant.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     role: 'system',<br/>
        ///     content: 'You are a transfer assistant designed to facilitate call transfers. Your core responsibility is to manage the transfer process efficiently.\n\n## Core Responsibility\n- Facilitate the transfer process by using transferSuccessful or transferCancel tools appropriately\n\n## When to Respond\n- Answer questions about the transfer process or provide summaries when specifically asked by the operator\n- Respond to direct questions about the current transfer situation\n\n## What to Avoid\n- Do not discuss topics unrelated to the transfer\n- Do not engage in general conversation\n- Keep all interactions focused on facilitating the transfer\n\n## Transfer Tools\n- Use transferSuccessful when the transfer should proceed\n- Use transferCancel when the transfer cannot be completed\n\nStay focused on your core responsibility of facilitating transfers.'<br/>
        ///   }<br/>
        /// ]```<br/>
        /// **Default Behavior:** If you don't provide any messages or don't include a system message as the first message, the default system message above will be automatically added.<br/>
        /// **Override Default:** To replace the default system message, provide your own system message as the first message in the array.<br/>
        /// **Add Context:** You can provide additional messages (user, assistant, etc.) to add context while keeping the default system message, or combine them with your custom system message.
        /// </param>
        /// <param name="tools">
        /// Tools available to the transfer assistant during warm-transfer-experimental.<br/>
        /// **Default Behavior:** The transfer assistant will ALWAYS have both `transferSuccessful` and `transferCancel` tools automatically added, regardless of what you provide here.<br/>
        /// **Default Tools:**<br/>
        /// - `transferSuccessful`: "Call this function to confirm the transfer is successful and connect the customer. Use this when you detect a human has answered and is ready to take the call."<br/>
        /// - `transferCancel`: "Call this function to cancel the transfer when no human answers or transfer should not proceed. Use this when you detect voicemail, busy signal, or no answer."<br/>
        /// **Customization:** You can override the default tools by providing `transferSuccessful` and/or `transferCancel` tools with custom `function` or `messages` configurations.<br/>
        /// **Additional Tools:** You can also provide other tools, but the two transfer tools will always be present and available to the assistant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferAssistantModel(
            global::G.TransferAssistantModelProvider provider,
            string model,
            byte[]? messages,
            byte[]? tools)
        {
            this.Provider = provider;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssistantModel" /> class.
        /// </summary>
        public TransferAssistantModel()
        {
        }
    }
}