//HintName: G.Models.DeleteResponseVariant1TriggersChatEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a specific trigger event
    /// </summary>
    public sealed partial class DeleteResponseVariant1TriggersChatEnd
    {
        /// <summary>
        /// Webhooks to execute immediately when event fires
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::System.Collections.Generic.IList<global::G.DeleteResponseVariant1TriggersChatEndWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1TriggersChatEnd" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// Webhooks to execute immediately when event fires
        /// </param>
        public DeleteResponseVariant1TriggersChatEnd(
            global::System.Collections.Generic.IList<global::G.DeleteResponseVariant1TriggersChatEndWebhook>? webhooks)
        {
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1TriggersChatEnd" /> class.
        /// </summary>
        public DeleteResponseVariant1TriggersChatEnd()
        {
        }
    }
}