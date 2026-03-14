//HintName: G.Models.StructuredDocumentMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The metadata for a document as an arbitrary JSON object. Properties of this object can be used by document level filter attributes.<br/>
    /// Example: {"region":"EU","industry":"banking","year":2024}
    /// </summary>
    public sealed partial class StructuredDocumentMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}