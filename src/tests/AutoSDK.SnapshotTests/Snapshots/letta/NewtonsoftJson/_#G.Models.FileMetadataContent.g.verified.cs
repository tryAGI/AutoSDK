//HintName: G.Models.FileMetadataContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional full-text content of the file; only populated on demand due to its size.
    /// </summary>
    public sealed partial class FileMetadataContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}