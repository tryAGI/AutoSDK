//HintName: G.Models.StructuredDocumentSectionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary object that becomes document part level metadata on any document part created <br/>
    /// by this section. Properties of this object can be used by document part level <br/>
    /// filters if defined as a corpus filter attribute.
    /// </summary>
    public sealed partial class StructuredDocumentSectionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}