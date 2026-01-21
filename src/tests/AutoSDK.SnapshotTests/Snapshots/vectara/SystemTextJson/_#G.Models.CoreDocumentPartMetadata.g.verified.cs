//HintName: G.Models.CoreDocumentPartMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.<br/>
    /// Example: {"nice_rank":9000}
    /// </summary>
    public sealed partial class CoreDocumentPartMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}