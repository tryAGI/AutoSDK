//HintName: G.Models.UpdateDocumentRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The metadata for a document as an arbitrary object. Properties of this object can be used by document level filter attributes.<br/>
    /// Example: {"title":"2024 ESG Annual Report \u2013 EuroBank","region":"EU","industry":"banking","year":2024}
    /// </summary>
    public sealed partial class UpdateDocumentRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}