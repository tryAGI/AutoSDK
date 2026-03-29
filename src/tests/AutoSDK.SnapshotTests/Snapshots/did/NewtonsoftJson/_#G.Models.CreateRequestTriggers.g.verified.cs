//HintName: G.Models.CreateRequestTriggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event-based trigger configuration for the Agent.
    /// </summary>
    public sealed partial class CreateRequestTriggers
    {
        /// <summary>
        /// Configuration triggered when a chat session ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.CreateRequestTriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestTriggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration triggered when a chat session ends.
        /// </param>
        public CreateRequestTriggers(
            global::G.CreateRequestTriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestTriggers" /> class.
        /// </summary>
        public CreateRequestTriggers()
        {
        }
    }
}