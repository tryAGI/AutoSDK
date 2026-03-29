//HintName: G.Models.ListGroupsAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Group ID cursor for pagination. Returns groups that come after this group ID in the specified sort order
    /// </summary>
    public sealed partial class ListGroupsAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}