//HintName: G.Models.TurnTokenDataContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text content. For tool turns, client tokenizes this with loss_mask=0.
    /// </summary>
    public sealed partial class TurnTokenDataContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}