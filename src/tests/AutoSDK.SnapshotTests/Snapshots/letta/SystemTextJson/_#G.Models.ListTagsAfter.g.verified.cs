//HintName: G.Models.ListTagsAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tag cursor for pagination. Returns tags that come after this tag in the specified sort order
    /// </summary>
    public sealed partial class ListTagsAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}