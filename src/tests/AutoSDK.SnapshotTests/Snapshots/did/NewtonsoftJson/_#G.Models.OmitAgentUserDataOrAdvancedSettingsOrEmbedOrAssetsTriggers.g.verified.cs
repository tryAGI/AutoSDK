//HintName: G.Models.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trigger configurations for this agent
    /// </summary>
    public sealed partial class OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers
    {
        /// <summary>
        /// Configuration for a specific trigger event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat/end")]
        public global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd? ChatEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers" /> class.
        /// </summary>
        /// <param name="chatEnd">
        /// Configuration for a specific trigger event
        /// </param>
        public OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers(
            global::G.OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggersChatEnd? chatEnd)
        {
            this.ChatEnd = chatEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers" /> class.
        /// </summary>
        public OmitAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers()
        {
        }
    }
}