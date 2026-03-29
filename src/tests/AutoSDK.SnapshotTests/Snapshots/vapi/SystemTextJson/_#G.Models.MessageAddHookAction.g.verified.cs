//HintName: G.Models.MessageAddHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageAddHookAction
    {
        /// <summary>
        /// This is the type of action - must be "message.add"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageAddHookActionTypeJsonConverter))]
        public global::G.MessageAddHookActionType Type { get; set; }

        /// <summary>
        /// The message to add to the conversation in OpenAI format<br/>
        /// Example: {"role":"system","content":"Context update from hook"}
        /// </summary>
        /// <example>{"role":"system","content":"Context update from hook"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIMessage Message { get; set; }

        /// <summary>
        /// Whether to trigger an assistant response after adding the message<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerResponseEnabled")]
        public bool? TriggerResponseEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAddHookAction" /> class.
        /// </summary>
        /// <param name="message">
        /// The message to add to the conversation in OpenAI format<br/>
        /// Example: {"role":"system","content":"Context update from hook"}
        /// </param>
        /// <param name="type">
        /// This is the type of action - must be "message.add"
        /// </param>
        /// <param name="triggerResponseEnabled">
        /// Whether to trigger an assistant response after adding the message<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageAddHookAction(
            global::G.OpenAIMessage message,
            global::G.MessageAddHookActionType type,
            bool? triggerResponseEnabled)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TriggerResponseEnabled = triggerResponseEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAddHookAction" /> class.
        /// </summary>
        public MessageAddHookAction()
        {
        }
    }
}