//HintName: G.Models.DependencyGraphSpdxSbomSbomPackagesExternalRefs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomPackagesExternalRefs
    {
        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: PACKAGE-MANAGER
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceCategory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceCategory { get; set; }

        /// <summary>
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceLocator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceLocator { get; set; }

        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}