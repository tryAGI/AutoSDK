//HintName: G.Models.ListAgentsForArchiveAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent ID cursor for pagination. Returns agents that come after this agent ID in the specified sort order
    /// </summary>
    public sealed partial class ListAgentsForArchiveAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}