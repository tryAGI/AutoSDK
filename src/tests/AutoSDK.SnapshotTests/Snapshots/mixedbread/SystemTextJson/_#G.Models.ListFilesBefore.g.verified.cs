//HintName: G.Models.ListFilesBefore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
    /// </summary>
    public sealed partial class ListFilesBefore
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}