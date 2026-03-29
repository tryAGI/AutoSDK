//HintName: G.Models.ConversationMessageRequestOverrideModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model handle to use for this request instead of the agent's default model. This allows sending a message to a different model without changing the agent's configuration.
    /// </summary>
    public sealed partial class ConversationMessageRequestOverrideModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}