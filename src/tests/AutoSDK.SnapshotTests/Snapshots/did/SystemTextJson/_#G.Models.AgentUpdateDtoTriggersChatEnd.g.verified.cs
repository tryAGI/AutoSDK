//HintName: G.Models.AgentUpdateDtoTriggersChatEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration triggered when a chat session ends.
    /// </summary>
    public sealed partial class AgentUpdateDtoTriggersChatEnd
    {
        /// <summary>
        /// Webhooks executed when the event occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::G.AgentUpdateDtoTriggersChatEndWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoTriggersChatEnd" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// Webhooks executed when the event occurs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateDtoTriggersChatEnd(
            global::System.Collections.Generic.IList<global::G.AgentUpdateDtoTriggersChatEndWebhook>? webhooks)
        {
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoTriggersChatEnd" /> class.
        /// </summary>
        public AgentUpdateDtoTriggersChatEnd()
        {
        }
    }
}