//HintName: G.Models.CoreDocumentMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary object of document level metadata. Properties of this object<br/>
    /// can be used by document filter if defined as a corpus filter attribute.
    /// </summary>
    public sealed partial class CoreDocumentMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocumentMetadata" /> class.
        /// </summary>
        public CoreDocumentMetadata(
 )
        {
        }
    }
}