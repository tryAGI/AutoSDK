//HintName: G.Models.CreateConversationIsolatedBlockLabels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of block labels that should be isolated (conversation-specific) rather than shared across conversations. New blocks will be created as copies of the agent's blocks with these labels.
    /// </summary>
    public sealed partial class CreateConversationIsolatedBlockLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}