//HintName: G.Models.ConversationModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
    /// </summary>
    public sealed partial class ConversationModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}