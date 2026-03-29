//HintName: G.Models.CreateRequestTriggersChatEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration triggered when a chat session ends.
    /// </summary>
    public sealed partial class CreateRequestTriggersChatEnd
    {
        /// <summary>
        /// Webhooks executed when the event occurs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks")]
        public global::System.Collections.Generic.IList<global::G.CreateRequestTriggersChatEndWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestTriggersChatEnd" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// Webhooks executed when the event occurs.
        /// </param>
        public CreateRequestTriggersChatEnd(
            global::System.Collections.Generic.IList<global::G.CreateRequestTriggersChatEndWebhook>? webhooks)
        {
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestTriggersChatEnd" /> class.
        /// </summary>
        public CreateRequestTriggersChatEnd()
        {
        }
    }
}