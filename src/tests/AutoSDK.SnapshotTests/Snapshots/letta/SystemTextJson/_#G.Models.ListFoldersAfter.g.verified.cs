//HintName: G.Models.ListFoldersAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Folder ID cursor for pagination. Returns folders that come after this folder ID in the specified sort order
    /// </summary>
    public sealed partial class ListFoldersAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}