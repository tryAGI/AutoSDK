//HintName: G.Models.ListFilesAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
    /// </summary>
    public sealed partial class ListFilesAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}