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
        [global::Newtonsoft.Json.JsonProperty("referenceCategory", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceCategory { get; set; } = default!;

        /// <summary>
        /// A locator for the particular external resource this reference refers to.<br/>
        /// Example: pkg:gem/rails@6.0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceLocator", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceLocator { get; set; } = default!;

        /// <summary>
        /// The category of reference to an external resource this reference refers to.<br/>
        /// Example: purl
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenceType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReferenceType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}