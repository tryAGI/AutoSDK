//HintName: G.Models.DeleteResponseVariant1Triggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trigger configurations for this agent
    /// </summary>
    public sealed partial class DeleteResponseVariant1Triggers
    {
        /// <summary>
        /// Configuration for a specific trigger event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.DeleteResponseVariant1TriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1Triggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration for a specific trigger event
        /// </param>
        public DeleteResponseVariant1Triggers(
            global::G.DeleteResponseVariant1TriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1Triggers" /> class.
        /// </summary>
        public DeleteResponseVariant1Triggers()
        {
        }
    }
}